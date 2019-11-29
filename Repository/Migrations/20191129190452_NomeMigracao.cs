using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class NomeMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cep = table.Column<string>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Localidade = table.Column<string>(nullable: true),
                    Uf = table.Column<string>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.EnderecoId);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    GeneroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.GeneroId);
                });

            migrationBuilder.CreateTable(
                name: "Quartos",
                columns: table => new
                {
                    IdQuarto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeQuarto = table.Column<string>(nullable: true),
                    PrecoQuarto = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quartos", x => x.IdQuarto);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 100, nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    Preco = table.Column<double>(nullable: false),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    CategoriaId = table.Column<int>(nullable: true),
                    Imagem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ProdutoId);
                    table.ForeignKey(
                        name: "FK_Produtos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    IdServico = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeServico = table.Column<string>(nullable: true),
                    PrecoServico = table.Column<double>(nullable: false),
                    CategoriaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.IdServico);
                    table.ForeignKey(
                        name: "FK_Servicos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    EnderecoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuarios_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "EnderecoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Nome = table.Column<string>(nullable: true),
                    GeneroId = table.Column<int>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Rg = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sobrenome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_Clientes_Generos_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Generos",
                        principalColumn: "GeneroId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItensVenda",
                columns: table => new
                {
                    ItemVendaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProdutoId = table.Column<int>(nullable: true),
                    Preco = table.Column<double>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    CarrinhoId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensVenda", x => x.ItemVendaId);
                    table.ForeignKey(
                        name: "FK_ItensVenda_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    Peso = table.Column<double>(nullable: false),
                    Imagem = table.Column<string>(nullable: true)
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
                name: "IX_Clientes_GeneroId",
                table: "Clientes",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensVenda_ProdutoId",
                table: "ItensVenda",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_GeneroId",
                table: "Pet",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_clienteIdCliente",
                table: "Pet",
                column: "clienteIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produtos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_CategoriaId",
                table: "Servicos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EnderecoId",
                table: "Usuarios",
                column: "EnderecoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItensVenda");

            migrationBuilder.DropTable(
                name: "Pet");

            migrationBuilder.DropTable(
                name: "Quartos");

            migrationBuilder.DropTable(
                name: "Servicos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Generos");
        }
    }
}
