using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leilao.Produto.Data.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Edital = table.Column<string>(type: "varchar(100)", nullable: false),
                    Comitentes = table.Column<string>(type: "varchar(100)", nullable: false),
                    Meta = table.Column<string>(type: "varchar(100)", nullable: false),
                    Acressimo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Natureza = table.Column<string>(type: "varchar(100)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    ValorInicial = table.Column<string>(type: "varchar(100)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
