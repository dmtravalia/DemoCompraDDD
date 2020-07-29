using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace DemoCompra.Infra.Data.Migrations
{
    public partial class PrimeiraMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compra");
        }
    }
}
