using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class AddPet333333333333333 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    IdPet = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    clienteIdCliente = table.Column<int>(nullable: true),
                    GeneroId = table.Column<int>(nullable: true),
                    Raca = table.Column<string>(nullable: true),
                    Castragem = table.Column<string>(nullable: true),
                    Pelagem = table.Column<string>(nullable: true),
                    Idade = table.Column<int>(nullable: false),
                    Porte = table.Column<string>(nullable: true),
                    Peso = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.IdPet);
                    table.ForeignKey(
                        name: "FK_Pet_Generos_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Generos",
                        principalColumn: "GeneroId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pet_Clientes_clienteIdCliente",
                        column: x => x.clienteIdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pet_GeneroId",
                table: "Pet",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_clienteIdCliente",
                table: "Pet",
                column: "clienteIdCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pet");
        }
    }
}
