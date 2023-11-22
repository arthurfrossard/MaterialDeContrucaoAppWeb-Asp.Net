using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaterialDeContrucaoAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarAdicionarRelacionamentoProdutoMarca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_MarcaId",
                table: "Produtos",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Marcas_MarcaId",
                table: "Produtos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "MarcaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Marcas_MarcaId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_MarcaId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Produtos");
        }
    }
}
