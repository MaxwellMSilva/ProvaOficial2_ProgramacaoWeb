using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class initalMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Veiculo_Marca = table.Column<string>(type: "varchar(100)", nullable: false),
                    Veiculo_Modelo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Veiculo_Ano = table.Column<string>(type: "varchar(100)", nullable: false),
                    Veiculo_Quilometragem = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
