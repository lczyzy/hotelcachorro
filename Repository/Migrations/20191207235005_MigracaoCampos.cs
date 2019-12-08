﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class MigracaoCampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Deficiencia",
                table: "Clientes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deficiencia",
                table: "Clientes");
        }
    }
}
