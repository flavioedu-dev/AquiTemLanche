using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AquiTemLanche.Migrations
{
    public partial class PurchaseCartItemsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    PurchaseCartItemsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SnackId = table.Column<int>(type: "int", nullable: true),
                    PurchaseCartId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.PurchaseCartItemsId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Snacks_SnackId",
                        column: x => x.SnackId,
                        principalTable: "Snacks",
                        principalColumn: "SnackId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_SnackId",
                table: "ShoppingCartItems",
                column: "SnackId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");
        }
    }
}
