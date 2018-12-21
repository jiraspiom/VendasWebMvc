using Microsoft.EntityFrameworkCore.Migrations;

namespace VendasWebMvc.Migrations
{
    public partial class outrasEntidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "RegistroDeVenda");

            migrationBuilder.AddColumn<double>(
                name: "Valor",
                table: "RegistroDeVenda",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Valor",
                table: "RegistroDeVenda");

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "RegistroDeVenda",
                nullable: false,
                defaultValue: 0);
        }
    }
}
