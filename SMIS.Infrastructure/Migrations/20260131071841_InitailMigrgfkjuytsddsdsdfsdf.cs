using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitailMigrgfkjuytsddsdsdfsdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4293fcc4-9265-4a52-a08b-83e3f4cc84bf", "AQAAAAIAAYagAAAAEBfLFSqW0Tw2CGiNdg1IO6OaIT5I80SjZdcYEzav1S4jIx6QdLlfS5bdh5DPcAiH1A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fba6e935-93ad-48c8-ab0e-0efa40c6e29c", "AQAAAAIAAYagAAAAEDtvzVfPEw7J8AqwmQa847dh3kead7+nKFi/TdtT4erKKf715sixoYFtAa2LTRcgsA==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(6970), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(6978), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(7255), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(7261), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(7264), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(7265), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(7271), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(7279), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(7284), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(7285), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(7288), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(6562), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(6568), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(6656), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(6660), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(6661), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 600, DateTimeKind.Unspecified).AddTicks(6667), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 600, DateTimeKind.Unspecified).AddTicks(6948), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 600, DateTimeKind.Unspecified).AddTicks(6952), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 609, DateTimeKind.Local).AddTicks(9961), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 609, DateTimeKind.Unspecified).AddTicks(9974), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 609, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4880), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4883), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4887), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4890), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4887) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4895), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4899), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4904), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4906), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4911), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4914), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4918), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4921), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4926), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4928), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(2884), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(2901), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4020), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4029), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4814), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4826), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4839), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4843), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4848), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4851), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4856), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4860), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4865), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4867), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4872), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4875), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4872) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(2947), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5621), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5624), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5627), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5630), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5634), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5637), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5641), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5645), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5649), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5652), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5586), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5655), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5658), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5661), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5665), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5668), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5672), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5675), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5679), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5682), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5685), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5593), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5688), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5691), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5597), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5600), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5604), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5607), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5611), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5617), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5253), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5666), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5670), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5673), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5635), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5642), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5646), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5650), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5653), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5656), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5659), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5662), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(4840), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(4846), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(4848), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(4851), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(4852), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(4855), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(4856), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(4858), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 602, DateTimeKind.Local).AddTicks(1470), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 602, DateTimeKind.Unspecified).AddTicks(1492), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 602, DateTimeKind.Local).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 609, DateTimeKind.Local).AddTicks(4419), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 609, DateTimeKind.Unspecified).AddTicks(4475), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 609, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 609, DateTimeKind.Local).AddTicks(5093), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 609, DateTimeKind.Unspecified).AddTicks(5100), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 609, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 598, DateTimeKind.Local).AddTicks(9928), new DateTime(2026, 7, 31, 7, 18, 40, 598, DateTimeKind.Utc).AddTicks(7608), new DateTime(2026, 1, 21, 7, 18, 40, 598, DateTimeKind.Utc).AddTicks(7557), new DateTime(2026, 1, 31, 11, 48, 40, 599, DateTimeKind.Local).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(2699), new DateTime(2026, 8, 31, 7, 18, 40, 600, DateTimeKind.Utc).AddTicks(2665), new DateTime(2026, 1, 26, 7, 18, 40, 600, DateTimeKind.Utc).AddTicks(2663), new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(4216), new DateTime(2026, 4, 30, 7, 18, 40, 600, DateTimeKind.Utc).AddTicks(4204), new DateTime(2026, 1, 16, 7, 18, 40, 600, DateTimeKind.Utc).AddTicks(4203), new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(4957), new DateTime(2026, 1, 11, 7, 18, 40, 600, DateTimeKind.Utc).AddTicks(4951), new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9249), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 600, DateTimeKind.Unspecified).AddTicks(9546), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9875), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 600, DateTimeKind.Unspecified).AddTicks(9879), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9880), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 600, DateTimeKind.Unspecified).AddTicks(9888), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9889), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 600, DateTimeKind.Unspecified).AddTicks(9892), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9893), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 600, DateTimeKind.Unspecified).AddTicks(9896), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9897), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 600, DateTimeKind.Unspecified).AddTicks(9900), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9901), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 600, DateTimeKind.Unspecified).AddTicks(9903), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9904), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 600, DateTimeKind.Unspecified).AddTicks(9907), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(1820), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(1832), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2039), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2043), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2048), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(2051), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2005), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(2009), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2011), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(2016), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2017), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(2020), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2021), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(2024), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2025), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(2028), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2028), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(2031), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2032), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(2035), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2036), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(2038), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(8347), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(8599), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(8571), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(8574), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(8580), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(8583), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(8586), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(8589), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(8592), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(8595), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_StockBatch_UnitId",
                table: "StockBatch",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockBatch_UnitOfMeasure_UnitId",
                table: "StockBatch",
                column: "UnitId",
                principalTable: "UnitOfMeasure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockBatch_UnitOfMeasure_UnitId",
                table: "StockBatch");

            migrationBuilder.DropIndex(
                name: "IX_StockBatch_UnitId",
                table: "StockBatch");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5f8c6f1f-06f1-4851-9a98-ccdd47be7c4b", "AQAAAAIAAYagAAAAEBprDTNHNdJBhfP2FHPBvRBixeBu8YdJvRxE3yd+wxlpwi8bfi4xxlFEofSU7BPtOw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ad09dc9-57d1-484b-9738-11a16ea83f01", "AQAAAAIAAYagAAAAEPUNMwgNeqOtn8nu1Nd1FTpoYz0yuYXtH8/FqwSYMRwjomRgmInOaaGgVq1pcfCY+w==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7053), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(7063), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7369), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(7376), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7378), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(7381), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7382), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(7385), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7394), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(7399), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7400), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(7403), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(4942), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4947), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(5032), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(5036), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(5037), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(5040), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 821, DateTimeKind.Unspecified).AddTicks(4904), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 821, DateTimeKind.Unspecified).AddTicks(5247), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 821, DateTimeKind.Unspecified).AddTicks(5251), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 830, DateTimeKind.Local).AddTicks(212), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 830, DateTimeKind.Unspecified).AddTicks(228), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 830, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4945), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4951), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4956), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4959), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4964), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4967), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4971), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4974), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4979), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4982), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4986), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4989), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4994), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4997), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(2841), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(2870), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4063), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4071), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4883), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4889), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4903), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4907), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4912), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4916), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4921), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4924), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4929), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4932), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4937), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4940), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 818, DateTimeKind.Unspecified).AddTicks(9025), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2629), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2632), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2663), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2667), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2672), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2675), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2680), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2684), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2688), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2691), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2586), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2695), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2698), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2702), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2705), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2710), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2714), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2717), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2720), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2724), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2727), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2595), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2730), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2734), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2600), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2603), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2607), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2610), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2621), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2625), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(3719), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4127), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4130), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4133), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4099), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4103), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4106), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4109), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4113), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4116), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4119), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4122), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(3265), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(3280), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(3282), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(3285), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(3285), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(3288), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(3289), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(3292), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(9215), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(9234), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(9216) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 829, DateTimeKind.Local).AddTicks(4759), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 829, DateTimeKind.Unspecified).AddTicks(4801), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 829, DateTimeKind.Local).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 829, DateTimeKind.Local).AddTicks(5475), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 829, DateTimeKind.Unspecified).AddTicks(5493), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 829, DateTimeKind.Local).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 819, DateTimeKind.Local).AddTicks(7060), new DateTime(2026, 7, 31, 7, 15, 55, 819, DateTimeKind.Utc).AddTicks(4851), new DateTime(2026, 1, 21, 7, 15, 55, 819, DateTimeKind.Utc).AddTicks(4804), new DateTime(2026, 1, 31, 11, 45, 55, 820, DateTimeKind.Local).AddTicks(4144) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 820, DateTimeKind.Local).AddTicks(9852), new DateTime(2026, 8, 31, 7, 15, 55, 820, DateTimeKind.Utc).AddTicks(9824), new DateTime(2026, 1, 26, 7, 15, 55, 820, DateTimeKind.Utc).AddTicks(9823), new DateTime(2026, 1, 31, 11, 45, 55, 820, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(2081), new DateTime(2026, 4, 30, 7, 15, 55, 821, DateTimeKind.Utc).AddTicks(2064), new DateTime(2026, 1, 16, 7, 15, 55, 821, DateTimeKind.Utc).AddTicks(2063), new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(2853), new DateTime(2026, 1, 11, 7, 15, 55, 821, DateTimeKind.Utc).AddTicks(2847), new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(7535), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 821, DateTimeKind.Unspecified).AddTicks(7822), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8150), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 821, DateTimeKind.Unspecified).AddTicks(8158), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8160), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 821, DateTimeKind.Unspecified).AddTicks(8163), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8164), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 821, DateTimeKind.Unspecified).AddTicks(8167), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8167), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 821, DateTimeKind.Unspecified).AddTicks(8170), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8171), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 821, DateTimeKind.Unspecified).AddTicks(8174), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8175), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 821, DateTimeKind.Unspecified).AddTicks(8178), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8179), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 821, DateTimeKind.Unspecified).AddTicks(8182), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(43), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(48), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(240), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(244), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(245), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(248), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(249), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(252), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(206), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(213), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(214), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(217), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(218), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(221), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(221), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(224), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(225), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(228), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(229), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(232), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(233), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(236), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(236), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(239), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(6903), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(7236), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(7198), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(7206), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(7211), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(7215), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(7219), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(7223), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(7227), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
