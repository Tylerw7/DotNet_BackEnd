using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ecom_pwa_backend.data.Migrations
{
    /// <inheritdoc />
    public partial class OrderEntityAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BuyerEmail = table.Column<string>(type: "TEXT", nullable: false),
                    ShippingAddress_Name = table.Column<string>(type: "TEXT", nullable: false),
                    ShippingAddress_Line1 = table.Column<string>(type: "TEXT", nullable: false),
                    ShippingAddress_Line2 = table.Column<string>(type: "TEXT", nullable: true),
                    ShippingAddress_City = table.Column<string>(type: "TEXT", nullable: false),
                    ShippingAddress_State = table.Column<string>(type: "TEXT", nullable: false),
                    ShippingAddress_PostalCode = table.Column<string>(type: "TEXT", nullable: false),
                    ShippingAddress_Country = table.Column<string>(type: "TEXT", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Subtotal = table.Column<long>(type: "INTEGER", nullable: false),
                    DeliveryFee = table.Column<long>(type: "INTEGER", nullable: false),
                    Discount = table.Column<long>(type: "INTEGER", nullable: false),
                    PaymentIntentId = table.Column<string>(type: "TEXT", nullable: true),
                    OrderStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    PaymentSummary_Last4 = table.Column<int>(type: "INTEGER", nullable: false),
                    PaymentSummary_Brans = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentSummary_ExpMonth = table.Column<int>(type: "INTEGER", nullable: false),
                    PaymentSummary_ExpYear = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemOrdered_ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemOrdered_Name = table.Column<string>(type: "TEXT", nullable: false),
                    ItemOrdered_PrictureUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<long>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d2b0ca6-90af-4f88-8c18-9f0146a802e7",
                column: "ConcurrencyStamp",
                value: "91c6dc54-cb2e-4255-bf78-15573501a664");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b0e7f5f-55cb-44d3-9a5d-bcc20e0c176c",
                column: "ConcurrencyStamp",
                value: "6913597d-31e4-4515-bfd1-8574a68178eb");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Orders");

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
    }
}
