﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

namespace Repository.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Domain.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .IsRequired();

                    b.Property<DateTime>("CriadoEm");

                    b.Property<DateTime?>("DataNascimento")
                        .IsRequired();

                    b.Property<int?>("EnderecoId");

                    b.Property<int?>("GeneroId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Rg")
                        .IsRequired();

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Telefone")
                        .IsRequired();

                    b.Property<string>("TelefoneContato");

                    b.HasKey("IdCliente");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("GeneroId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Domain.Endend", b =>
                {
                    b.Property<string>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Cidade");

                    b.Property<string>("Descricao");

                    b.Property<string>("uf");

                    b.HasKey("Codigo");

                    b.ToTable("Endend");
                });

            modelBuilder.Entity("Domain.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("End");

                    b.Property<string>("Uf");

                    b.HasKey("EnderecoId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Domain.Genero", b =>
                {
                    b.Property<int>("GeneroId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("GeneroId");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("Domain.ItemVenda", b =>
                {
                    b.Property<int>("IdVendaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.Property<double>("Preco");

                    b.Property<int>("Quantidade");

                    b.Property<int?>("ReservaIdReserva");

                    b.Property<int?>("ServicoIdServico");

                    b.HasKey("IdVendaId");

                    b.HasIndex("ReservaIdReserva");

                    b.HasIndex("ServicoIdServico");

                    b.ToTable("ItensVendas");
                });

            modelBuilder.Entity("Domain.Pet", b =>
                {
                    b.Property<int>("IdPet")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Castragem")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("GeneroId");

                    b.Property<int>("Idade");

                    b.Property<string>("Imagem");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Pelagem")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<double>("Peso");

                    b.Property<string>("Porte")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Raca")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("clienteIdCliente");

                    b.HasKey("IdPet");

                    b.HasIndex("GeneroId");

                    b.HasIndex("clienteIdCliente");

                    b.ToTable("Pet");
                });

            modelBuilder.Entity("Domain.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoriaId");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Imagem");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<double?>("Preco")
                        .IsRequired();

                    b.Property<int?>("Quantidade")
                        .IsRequired();

                    b.HasKey("ProdutoId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Domain.Quarto", b =>
                {
                    b.Property<int>("IdQuarto")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("InfoAdicional");

                    b.Property<string>("NomeQuarto")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<double>("PrecoQuarto");

                    b.HasKey("IdQuarto");

                    b.ToTable("Quartos");
                });

            modelBuilder.Entity("Domain.Servico", b =>
                {
                    b.Property<int>("IdServico")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoriaId");

                    b.Property<string>("NomeServico")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<double>("PrecoServico");

                    b.HasKey("IdServico");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("Domain.TempList", b =>
                {
                    b.Property<int>("TempId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.Property<double>("Preco");

                    b.Property<int>("Quantidade");

                    b.Property<int?>("ServicoIdServico");

                    b.HasKey("TempId");

                    b.HasIndex("ServicoIdServico");

                    b.ToTable("TemList");
                });

            modelBuilder.Entity("Domain.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("Email");

                    b.Property<int?>("EnderecoId");

                    b.Property<string>("Senha");

                    b.HasKey("UsuarioId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("HotelCachorro.Model.Reserva", b =>
                {
                    b.Property<int>("IdReserva")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataEntrada");

                    b.Property<DateTime>("DataSaida");

                    b.Property<int?>("PetIdPet");

                    b.Property<int?>("QuartoIdQuarto");

                    b.Property<double>("ValorTotal");

                    b.HasKey("IdReserva");

                    b.HasIndex("PetIdPet");

                    b.HasIndex("QuartoIdQuarto");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("Domain.Cliente", b =>
                {
                    b.HasOne("Domain.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.HasOne("Domain.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroId");
                });

            modelBuilder.Entity("Domain.ItemVenda", b =>
                {
                    b.HasOne("HotelCachorro.Model.Reserva", "Reserva")
                        .WithMany("ItensVendidos")
                        .HasForeignKey("ReservaIdReserva");

                    b.HasOne("Domain.Servico", "Servico")
                        .WithMany()
                        .HasForeignKey("ServicoIdServico");
                });

            modelBuilder.Entity("Domain.Pet", b =>
                {
                    b.HasOne("Domain.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroId");

                    b.HasOne("Domain.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteIdCliente");
                });

            modelBuilder.Entity("Domain.Produto", b =>
                {
                    b.HasOne("Domain.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");
                });

            modelBuilder.Entity("Domain.Servico", b =>
                {
                    b.HasOne("Domain.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");
                });

            modelBuilder.Entity("Domain.TempList", b =>
                {
                    b.HasOne("Domain.Servico", "Servico")
                        .WithMany()
                        .HasForeignKey("ServicoIdServico");
                });

            modelBuilder.Entity("Domain.Usuario", b =>
                {
                    b.HasOne("Domain.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");
                });

            modelBuilder.Entity("HotelCachorro.Model.Reserva", b =>
                {
                    b.HasOne("Domain.Pet", "Pet")
                        .WithMany()
                        .HasForeignKey("PetIdPet");

                    b.HasOne("Domain.Quarto", "Quarto")
                        .WithMany()
                        .HasForeignKey("QuartoIdQuarto");
                });
#pragma warning restore 612, 618
        }
    }
}
