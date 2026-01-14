using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ecom_pwa_backend.data.Migrations
{
    /// <inheritdoc />
    public partial class FixedBrandupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PaymentSummary_Brans",
                table: "Orders",
                newName: "PaymentSummary_Brand");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d2b0ca6-90af-4f88-8c18-9f0146a802e7",
                column: "ConcurrencyStamp",
                value: "158c6405-b963-4777-b05e-9713e5e1aaf4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b0e7f5f-55cb-44d3-9a5d-bcc20e0c176c",
                column: "ConcurrencyStamp",
                value: "b1d7625a-9e47-43f5-8fa9-86b77040253a");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PaymentSummary_Brand",
                table: "Orders",
                newName: "PaymentSummary_Brans");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d2b0ca6-90af-4f88-8c18-9f0146a802e7",
                column: "ConcurrencyStamp",
                value: "ae55a814-0ccf-4688-a4b6-48ec7d2b37dd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b0e7f5f-55cb-44d3-9a5d-bcc20e0c176c",
                column: "ConcurrencyStamp",
                value: "72cfc9b6-064b-460a-8227-b61b8b00cd3d");
        }
    }
}
