using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class TelContato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Deficiencia",
                table: "Clientes",
                newName: "TelefoneContato");

            migrationBuilder.AddColumn<string>(
                name: "InfoAdicional",
                table: "Quartos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InfoAdicional",
                table: "Quartos");

            migrationBuilder.RenameColumn(
                name: "TelefoneContato",
                table: "Clientes",
                newName: "Deficiencia");
        }
    }
}
