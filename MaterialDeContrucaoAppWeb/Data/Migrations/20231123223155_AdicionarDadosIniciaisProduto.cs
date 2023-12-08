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
                    DisponibilidadeEstoque = true,
                    DataCadastro = DateTime.Now,
                    MarcaId = 2,
                },
                new Produto
                {
                    Nome = "Cimento CPII 50kg",
                    Descricao = "Base robusta, confiança em cada saco. Secagem rápida para lages!",
                    ImagemUrl = "/images/produtos/cimento.jpeg",
                    Preco = 35.00,
                    DisponibilidadeEstoque = true,
                    DataCadastro = DateTime.Now,
                    MarcaId = 1,
                },
                new Produto
                {
                    Nome = "Areia Lavada (MT)",
                    Descricao = "Pureza essencial para construção sólida, um metro de qualidade.",
                    ImagemUrl = "/images/produtos/areia.jpeg",
                    Preco = 120.00,
                    DisponibilidadeEstoque = true,
                    DataCadastro = DateTime.Now,
                    MarcaId = 3,
                },
                new Produto
                {
                    Nome = "Pedra 1 (MT)",
                    Descricao = "Fundação forte, um metro de durabilidade essencial.",
                    ImagemUrl = "/images/produtos/pedra1.jpeg",
                    Preco = 130.00,
                    DisponibilidadeEstoque = false,
                    DataCadastro = DateTime.Now,
                    MarcaId = 3,
                },
                new Produto
                {
                    Nome = "Argila 25KG",
                    Descricao = "Versatilidade compacta, essencial para projetos criativos.",
                    ImagemUrl = "/images/produtos/argila.jpg",
                    Preco = 7.00,
                    DisponibilidadeEstoque = true,
                    DataCadastro = DateTime.Now,
                    MarcaId = 4,
                },
                new Produto
                {
                    Nome = "Disjuntor Bipolar 70A DIN",
                    Descricao = "Proteção eficiente para circuitos elétricos com alta capacidade de corrente. Confiabilidade e segurança garantidas.",
                    ImagemUrl = "/images/produtos/disjuntor.webp",
                    Preco = 75.00,
                    DisponibilidadeEstoque = true,
                    DataCadastro = DateTime.Now,
                    MarcaId = 5,
                },
                new Produto
                {
                    Nome = "Torneira parede gourmet",
                    Descricao = "Elegância e funcionalidade para sua cozinha. Design moderno e alta performance em um só produto.",
                    ImagemUrl = "/images/produtos/torneira.jpg",
                    Preco = 90.00,
                    DisponibilidadeEstoque = true,
                    DataCadastro = DateTime.Now,
                    MarcaId = 6,
                },
                new Produto
                {
                    Nome = "Vaso de planta preto",
                    Descricao = "Sofisticação e estilo para seu espaço verde. Destaque suas plantas com este toque contemporâneo.",
                    ImagemUrl = "/images/produtos/vaso_planta.jpg",
                    Preco = 9.00,
                    DisponibilidadeEstoque = true,
                    DataCadastro = DateTime.Now,
                    MarcaId = 6,
                },
                new Produto
                {
                    Nome = "Armario de cozinha",
                    Descricao = "Organize com praticidade e elegância. Solução completa para um espaço funcional e charmoso.",
                    ImagemUrl = "/images/produtos/armario_cozinha.jpeg",
                    Preco = 550.00,
                    DisponibilidadeEstoque = true,
                    DataCadastro = DateTime.Now,
                    MarcaId = 7,
                },
                new Produto
                {
                    Nome = "Pia granito verde corumba 2mt",
                    Descricao = "Beleza natural e durabilidade. Transforme sua cozinha com estilo e qualidade excepcionais.",
                    ImagemUrl = "/images/produtos/pia_granito.webp",
                    Preco = 450.00,
                    DisponibilidadeEstoque = true,
                    DataCadastro = DateTime.Now,
                    MarcaId = 8,
                },
                new Produto
                {
                    Nome = "Tinta rende mais 3,6lt",
                    Descricao = "Cobertura superior, economia garantida. Transforme ambientes com menos produto e mais eficiência.",
                    ImagemUrl = "/images/produtos/tinta.jpeg",
                    Preco = 99.00,
                    DisponibilidadeEstoque = true,
                    DataCadastro = DateTime.Now,
                    MarcaId = 9,
                },
            };
        }



    }
}
