using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ecom_pwa_backend.data.Migrations
{
    /// <inheritdoc />
    public partial class updatedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d2b0ca6-90af-4f88-8c18-9f0146a802e7",
                column: "ConcurrencyStamp",
                value: "2ebc9a96-fc5a-46b4-a261-b46353a7e657");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b0e7f5f-55cb-44d3-9a5d-bcc20e0c176c",
                column: "ConcurrencyStamp",
                value: "ba87f437-79ea-49e0-a4a1-3e8732f33e9d");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d2b0ca6-90af-4f88-8c18-9f0146a802e7",
                column: "ConcurrencyStamp",
                value: "a1523aa5-8aa5-4053-89a9-5c3b1f50d74e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b0e7f5f-55cb-44d3-9a5d-bcc20e0c176c",
                column: "ConcurrencyStamp",
                value: "a55e3452-9322-4a4c-9af6-490e0544c35e");
        }
    }
}
