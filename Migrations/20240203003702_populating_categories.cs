using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AquiTemLanche.Migrations
{
    public partial class populating_categories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories(Name, Description) VALUES('Burguers', 'Hamburgues tradicionais e artesanais.')");
            migrationBuilder.Sql("INSERT INTO Categories(Name, Description) VALUES('Bebidas', 'Refrigerantes, sucos e vitaminas.')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories");
        }
    }
}
