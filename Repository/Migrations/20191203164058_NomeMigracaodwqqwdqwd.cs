using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class NomeMigracaodwqqwdqwd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Enderecos");

            migrationBuilder.RenameColumn(
                name: "UF",
                table: "Enderecos",
                newName: "Uf");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Enderecos",
                newName: "End");

            migrationBuilder.RenameColumn(
                name: "Complemento",
                table: "Enderecos",
                newName: "Cep");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Uf",
                table: "Enderecos",
                newName: "UF");

            migrationBuilder.RenameColumn(
                name: "End",
                table: "Enderecos",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "Cep",
                table: "Enderecos",
                newName: "Complemento");

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Enderecos",
                nullable: true);
        }
    }
}
