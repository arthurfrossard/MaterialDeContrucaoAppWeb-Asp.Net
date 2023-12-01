using MaterialDeContrucaoAppWeb.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaterialDeContrucaoAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosIniciaisProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new MatConstDBContext();
            context.Produtos.AddRange(ObterCargaInicialProduto());
            context.SaveChanges();
        }

        private IList<Produto> ObterCargaInicialProduto()
        {
            return new List<Produto>()
            {
                new Produto
                {
                    Nome = "Cimento CPIII 50kg",
                    Descricao = "Base robusta, confiança em cada saco. Resistência confiável para construção sólida!",
                    ImagemUrl = "/images/produtos/cimento.jpeg",
                    Preco = 29.00,
                    EntregaExpressa = true,
                    DataCadastro = DateTime.Now,
                    MarcaId = 2,
                },
                new Produto
                {
                    Nome = "Cimento CPII 50kg",
                    Descricao = "Base robusta, confiança em cada saco. Secagem rápida para lages!",
                    ImagemUrl = "/images/produtos/cimento.jpeg",
                    Preco = 35.00,
                    EntregaExpressa = true,
                    DataCadastro = DateTime.Now,
                    MarcaId = 1,
                },
                new Produto
                {
                    Nome = "Areia Lavada (MT)",
                    Descricao = "Pureza essencial para construção sólida, um metro de qualidade.",
                    ImagemUrl = "/images/produtos/areia.jpeg",
                    Preco = 120.00,
                    EntregaExpressa = true,
                    DataCadastro = DateTime.Now,
                    MarcaId = 3,
                },
                new Produto
                {
                    Nome = "Pedra 1 (MT)",
                    Descricao = "Fundação forte, um metro de durabilidade essencial.",
                    ImagemUrl = "/images/produtos/pedra1.jpeg",
                    Preco = 130.00,
                    EntregaExpressa = false,
                    DataCadastro = DateTime.Now,
                    MarcaId = 3,
                },
                new Produto
                {
                    Nome = "Argila 25KG",
                    Descricao = "Versatilidade compacta, essencial para projetos criativos.",
                    ImagemUrl = "/images/produtos/argila.jpg",
                    Preco = 7.50,
                    EntregaExpressa = true,
                    DataCadastro = DateTime.Now,
                    MarcaId = 4,
                },
            };
        }



    }
}
