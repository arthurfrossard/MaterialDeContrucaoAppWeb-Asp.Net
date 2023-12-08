using MaterialDeContrucaoAppWeb.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaterialDeContrucaoAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdiconarDadosIniciaisCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new MatConstDBContext();
            context.Categorias.AddRange(ObterCargaInicialCategoria());
            context.SaveChanges();
        }

        private IList<Categoria> ObterCargaInicialCategoria()
        {
            return new List<Categoria>()
            {
                new Categoria() { Descricao = "Ferramentas" },
                new Categoria() { Descricao = "Decoração" },
                new Categoria() { Descricao = "Jardim" },
                new Categoria() { Descricao = "Mobilia" },
                new Categoria() { Descricao = "Material básico" },
                new Categoria() { Descricao = "Ferragens" },
                new Categoria() { Descricao = "Ferramentas" },
                new Categoria() { Descricao = "Acabamento" },
                new Categoria() { Descricao = "Elétrica" },
                new Categoria() { Descricao = "Utilidades" },
                new Categoria() { Descricao = "Pintura" },
            };
        }
    }
}
