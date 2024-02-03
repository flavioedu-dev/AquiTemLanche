using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AquiTemLanche.Migrations
{
    public partial class populating_snacks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Snacks(CategoryId, Name, ShortDescription, DetailedDescription, Price, ImageUrl, ImageThumbnailUrl, IsFavoriteSnack, InStock)" +
                " VALUES('1', 'X-burguer', 'Carne, queijo e salada.', 'Um hambúrguer muito suculento.', 14.00, 'https://sachefmio.blob.core.windows.net/fotos/x-burguer-73517.jpg', 'https://sachefmio.blob.core.windows.net/fotos/x-burguer-73517.jpg', 0, 1)");
            migrationBuilder.Sql("INSERT INTO Snacks(CategoryId, Name, ShortDescription, DetailedDescription, Price, ImageUrl, ImageThumbnailUrl, IsFavoriteSnack, InStock)" +
                " VALUES('1', 'Giga-burguer', '150 de carne angus, bacon, queijo e salada.', 'O saber desse hambúrguer vai te surpreender.', 22.00, 'https://minervafoods.com/wp-content/uploads/2023/09/HamburguerAlcatraComBacon_1-scaled.jpg', 'https://minervafoods.com/wp-content/uploads/2023/09/HamburguerAlcatraComBacon_1-scaled.jpg', 0, 1)");

            migrationBuilder.Sql("INSERT INTO Snacks(CategoryId, Name, ShortDescription, DetailedDescription, Price, ImageUrl, ImageThumbnailUrl, IsFavoriteSnack, InStock)" +
                " VALUES('2', 'Coca lata', '350ml', 'Sabor refrescante.', 5.00, 'https://tezeio.vtexassets.com/arquivos/ids/1661537/7894900010015_1_1.png?v=638379866603870000', 'https://tezeio.vtexassets.com/arquivos/ids/1661537/7894900010015_1_1.png?v=638379866603870000', 0, 1)");
            migrationBuilder.Sql("INSERT INTO Snacks(CategoryId, Name, ShortDescription, DetailedDescription, Price, ImageUrl, ImageThumbnailUrl, IsFavoriteSnack, InStock)" +
               " VALUES('2', 'Coca zero lata', '350ml', 'Sabor refrescante sem açucar.', 5.00, 'https://tezeio.vtexassets.com/arquivos/ids/1661537/7894900010015_1_1.png?v=638379866603870000', 'https://tezeio.vtexassets.com/arquivos/ids/1661537/7894900010015_1_1.png?v=638379866603870000', 0, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Snacks");
        }
    }
}
