using MaterialDeContrucaoAppWeb.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaterialDeContrucaoAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarAdicionarDadosIniciaisMarcas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new MatConstDBContext();
            context.Marcas.AddRange(ObterCargaInicialMarca());
            context.SaveChanges();
        }

        private IList<Marca> ObterCargaInicialMarca()
        {
            return new List<Marca>()
            {
                new Marca() { Descricao = "Votoran" },
                new Marca() { Descricao = "Holcim" },
                new Marca() { Descricao = "Mineradora Serra Verde" },
                new Marca() { Descricao = "Argigoma" },
            };
        }
    }
}
