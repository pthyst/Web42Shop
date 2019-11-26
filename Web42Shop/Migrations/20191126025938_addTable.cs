using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web42Shop.Migrations
{
    public partial class addTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnoCarts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CartStatus_Id = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<int>(nullable: false),
                    TotalQuantity = table.Column<int>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    DateModify = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnoCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnoCarts_CartStatuses_CartStatus_Id",
                        column: x => x.CartStatus_Id,
                        principalTable: "CartStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnoCartDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cart_Id = table.Column<int>(nullable: false),
                    Product_Id = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    PriceSingle = table.Column<int>(nullable: false),
                    PriceTotal = table.Column<int>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    DateModify = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnoCartDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnoCartDetails_AnoCarts_Cart_Id",
                        column: x => x.Cart_Id,
                        principalTable: "AnoCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnoCartDetails_Products_Product_Id",
                        column: x => x.Product_Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnoCartDetails_Cart_Id",
                table: "AnoCartDetails",
                column: "Cart_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AnoCartDetails_Product_Id",
                table: "AnoCartDetails",
                column: "Product_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AnoCarts_CartStatus_Id",
                table: "AnoCarts",
                column: "CartStatus_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnoCartDetails");

            migrationBuilder.DropTable(
                name: "AnoCarts");
        }
    }
}
