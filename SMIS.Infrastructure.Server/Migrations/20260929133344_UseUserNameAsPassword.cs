using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class UseUserNameAsPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000001",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKlhy7lx1/qM3NGtL0ETO5AXxyobVtC66UBBAmw+bxawQIYCLg/C7sxqZ3YZ7gtibw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000002",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAFyC/O4IYX4EqJ6uemvh6qLpM+RL+BzKde7gcjIZ+EeBVHOMYioelyn63fO2B6l4Q==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000003",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEEqFdgkYefuwPNEn1jTrnNDT2cXrDJjRORjUibCLxCbqp+d/Kr5OMbAlYu4ecVLJCw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000004",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEACWFVheXXg44bF1SnLnHmLMlQio+gXK/CewFdlElgv/87pZMNXarSylYHHQM9TDzw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000005",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDmcAaC68oLRPp7N62uOQxou38wJStu0PDnRTX7dYoBbT8wnkzWzn2Fzm7FDRCDRzw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000006",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEB7prP7koVE/OUlR9s4TSx0GR+FdUNWA27pdMMmjDqKs6M7hBNN8p4/i/xKH6NPLug==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000007",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO1n88zJKKBvI/cGAfFb7BVkPvG1N5u7XG3fLVxfrTyKxpdaLJzpsdiPt6TBWNtFtQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000008",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAED9+2xjrPAaZ+O1VQQy0sIgJ0EplJ5KrJspahcT6o3VFNrdy0SvSC6oqfg2lVAmtug==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000009",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAED0yMSW4bbZ6Wgcrk1YnSidOV95fGUDyNIQ4L4hB4b5pVdp2NN/RInGrFcwCIFRcFg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000010",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEP2Dxp0S7KUBx6SLgPX0gGv5eBzRIhYkQUuP+FL1OUD8X34glIKrFNRnqMgsgvtEnQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000011",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPtblkwvX2iBlaKTmNy5Es40KZ04OXcOKC0Y0J2ZAHrbhbg8AChjPMIG2KI/Caq0nA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000012",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECbKJmJ0XQ08tMqwegOAlUNXOVYOfcFTRZ/bvegWVIDBLAwked7Mt1piJlMWzVusjw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000013",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOXSRj3/KMViNcF6fj3Z2pE5+MWC7CEBL3uziK5Pg+pvt44SYOn5L+ZrqH5tBehhDg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000014",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIxjMnDpe8QRnCOUl5C5oxwfF4A48n+oSX4yqe6nUhfGgASCAZlnqD0mVh/FrDOIsA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000015",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIoxjwiSMSqM3gzeKFCKj5vPuGOl/5qjBMCmV1j3YT1FXFVc6GHZiArNXc3kZ8VBOw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000016",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJOEjUXSHxHnUnYrH7jcO97NRqThEvOEb7hL5hWacH9PLNP1VHRAPfLih3PUZc1utQ==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000001",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE0b5rQqY7JDcZPxjM2CJxuH16YriSpqTeSLO+7ys67UK89RbdA3SnUC2ymyF8fZEw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000002",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE0b5rQqY7JDcZPxjM2CJxuH16YriSpqTeSLO+7ys67UK89RbdA3SnUC2ymyF8fZEw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000003",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE0b5rQqY7JDcZPxjM2CJxuH16YriSpqTeSLO+7ys67UK89RbdA3SnUC2ymyF8fZEw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000004",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE0b5rQqY7JDcZPxjM2CJxuH16YriSpqTeSLO+7ys67UK89RbdA3SnUC2ymyF8fZEw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000005",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE0b5rQqY7JDcZPxjM2CJxuH16YriSpqTeSLO+7ys67UK89RbdA3SnUC2ymyF8fZEw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000006",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE0b5rQqY7JDcZPxjM2CJxuH16YriSpqTeSLO+7ys67UK89RbdA3SnUC2ymyF8fZEw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000007",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE0b5rQqY7JDcZPxjM2CJxuH16YriSpqTeSLO+7ys67UK89RbdA3SnUC2ymyF8fZEw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000008",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE0b5rQqY7JDcZPxjM2CJxuH16YriSpqTeSLO+7ys67UK89RbdA3SnUC2ymyF8fZEw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000009",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE0b5rQqY7JDcZPxjM2CJxuH16YriSpqTeSLO+7ys67UK89RbdA3SnUC2ymyF8fZEw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000010",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE0b5rQqY7JDcZPxjM2CJxuH16YriSpqTeSLO+7ys67UK89RbdA3SnUC2ymyF8fZEw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000011",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE0b5rQqY7JDcZPxjM2CJxuH16YriSpqTeSLO+7ys67UK89RbdA3SnUC2ymyF8fZEw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000012",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE0b5rQqY7JDcZPxjM2CJxuH16YriSpqTeSLO+7ys67UK89RbdA3SnUC2ymyF8fZEw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000013",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE0b5rQqY7JDcZPxjM2CJxuH16YriSpqTeSLO+7ys67UK89RbdA3SnUC2ymyF8fZEw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000014",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE0b5rQqY7JDcZPxjM2CJxuH16YriSpqTeSLO+7ys67UK89RbdA3SnUC2ymyF8fZEw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000015",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE0b5rQqY7JDcZPxjM2CJxuH16YriSpqTeSLO+7ys67UK89RbdA3SnUC2ymyF8fZEw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000016",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE0b5rQqY7JDcZPxjM2CJxuH16YriSpqTeSLO+7ys67UK89RbdA3SnUC2ymyF8fZEw==");
        }
    }
}
