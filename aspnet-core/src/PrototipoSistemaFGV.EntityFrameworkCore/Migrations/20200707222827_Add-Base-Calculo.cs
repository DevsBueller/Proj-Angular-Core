using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrototipoSistemaFGV.Migrations
{
    public partial class AddBaseCalculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseCalculos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(nullable: false),
                    Documento = table.Column<string>(nullable: true),
                    Ano = table.Column<DateTime>(nullable: false),
                    DataEmissao = table.Column<DateTime>(nullable: false),
                    DataVencimento = table.Column<DateTime>(nullable: false),
                    ValorFatura = table.Column<decimal>(nullable: false),
                    ValorPago = table.Column<decimal>(nullable: false),
                    NumeroPedidoWeb = table.Column<int>(nullable: false),
                    CodigoConveniado = table.Column<string>(nullable: true),
                    Repasse = table.Column<int>(nullable: false),
                    CnpjConveniado = table.Column<string>(nullable: true),
                    DataVenda = table.Column<DateTime>(nullable: true),
                    DataCredito = table.Column<DateTime>(nullable: false),
                    ValorBruto = table.Column<decimal>(nullable: false),
                    ValorParcela = table.Column<decimal>(nullable: false),
                    ValorLiquido = table.Column<decimal>(nullable: false),
                    NumeroParcela = table.Column<int>(nullable: false),
                    TotalParcela = table.Column<int>(nullable: false),
                    Bandeira = table.Column<string>(nullable: true),
                    Estabelecimento = table.Column<string>(nullable: true),
                    NsuHost = table.Column<string>(nullable: true),
                    NsuTef = table.Column<string>(nullable: true),
                    ValorComissao = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseCalculos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseCalculos");
        }
    }
}
