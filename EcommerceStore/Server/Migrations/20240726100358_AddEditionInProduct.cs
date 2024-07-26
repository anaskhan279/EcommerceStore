using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceStore.Server.Migrations
{
    public partial class AddEditionInProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Editions_Products_ProductId",
                table: "Editions");

            migrationBuilder.DropIndex(
                name: "IX_Editions_ProductId",
                table: "Editions");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Editions");

            migrationBuilder.CreateTable(
                name: "EditionProduct",
                columns: table => new
                {
                    EditionsId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditionProduct", x => new { x.EditionsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_EditionProduct_Editions_EditionsId",
                        column: x => x.EditionsId,
                        principalTable: "Editions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EditionProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EditionProduct_ProductsId",
                table: "EditionProduct",
                column: "ProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EditionProduct");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Editions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Editions_ProductId",
                table: "Editions",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Editions_Products_ProductId",
                table: "Editions",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
