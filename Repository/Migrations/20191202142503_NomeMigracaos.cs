using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class NomeMigracaos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EndendCodigo",
                table: "Clientes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Endend",
                columns: table => new
                {
                    Codigo = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    UF = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endend", x => x.Codigo);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_EndendCodigo",
                table: "Clientes",
                column: "EndendCodigo");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Endend_EndendCodigo",
                table: "Clientes",
                column: "EndendCodigo",
                principalTable: "Endend",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Endend_EndendCodigo",
                table: "Clientes");

            migrationBuilder.DropTable(
                name: "Endend");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_EndendCodigo",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "EndendCodigo",
                table: "Clientes");
        }
    }
}
