using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ecom_pwa_backend.data.Migrations
{
    /// <inheritdoc />
    public partial class thirdIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d2b0ca6-90af-4f88-8c18-9f0146a802e7",
                column: "ConcurrencyStamp",
                value: "11279039-3ea9-4a41-b05b-e00b0c64c8d6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b0e7f5f-55cb-44d3-9a5d-bcc20e0c176c",
                column: "ConcurrencyStamp",
                value: "350ae104-0012-4609-8363-d42949ee0ef3");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d2b0ca6-90af-4f88-8c18-9f0146a802e7",
                column: "ConcurrencyStamp",
                value: "7ac54d19-9309-4889-89b8-e41d398b17b1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b0e7f5f-55cb-44d3-9a5d-bcc20e0c176c",
                column: "ConcurrencyStamp",
                value: "ca2e77a7-add1-4c7f-9f19-a373802b3d65");
        }
    }
}
