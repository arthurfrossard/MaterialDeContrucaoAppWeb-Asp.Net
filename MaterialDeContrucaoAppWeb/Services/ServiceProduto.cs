using MaterialDeContrucaoAppWeb.Models;

namespace MaterialDeContrucaoAppWeb.Services;

public class ServiceProduto : IServiceProduto
{
    public ServiceProduto()
        => CarregarListaInicial();

    private IList<Produto> _produtos;

    private void CarregarListaInicial()
    {
        _produtos = new List<Produto>()
        {
            new Produto
            {
                ProdutoId = 1,
                Nome = "Cimento CPIII 50kg",
                Descricao = "Base robusta, confiança em cada saco. Resistência confiável para construção sólida.!",
                ImagemUrl = "/images/produtos/cimento.jpeg",
                Preco = 33.00,
                EntregaExpressa = true,
                DataCadastro = DateTime.Now
            },
            new Produto
            {
                ProdutoId = 2,
                Nome = "Areia Lavada (MT)",
                Descricao = "Pureza essencial para construção sólida, um metro de qualidade.",
                ImagemUrl = "/images/produtos/areia.jpeg",
                Preco = 120.00,
                EntregaExpressa = true,
                DataCadastro = DateTime.Now
            },
            new Produto
            {
                ProdutoId = 3,
                Nome = "Pedra 1 (MT)",
                Descricao = "Fundação forte, um metro de durabilidade essencial.",
                ImagemUrl = "/images/produtos/pedra1.jpeg",
                Preco = 130.00,
                EntregaExpressa = false,
                DataCadastro = DateTime.Now
            },
            new Produto
            {
                ProdutoId = 4,
                Nome = "Argila 25KG",
                Descricao = "Versatilidade compacta, essencial para projetos criativos.",
                ImagemUrl = "/images/produtos/argila.jpg",
                Preco = 7.50,
                EntregaExpressa = true,
                DataCadastro = DateTime.Now
            },
        };
    }

    public IList<Produto> ObterTodos()
        => _produtos;

    public Produto Obter(int id)
        => ObterTodos().SingleOrDefault(item => item.ProdutoId == id);

    public void Incluir(Produto produto)
    {
        var proximoId = _produtos.Max(item => item.ProdutoId) + 1;
        produto.ProdutoId = proximoId;
        _produtos.Add(produto);
    }

    public void Alterar(Produto produto)
    {
        var produtoEncontrado = _produtos.SingleOrDefault(item => item.ProdutoId == produto.ProdutoId);
        produtoEncontrado.Nome = produto.Nome;
        produtoEncontrado.Descricao = produto.Descricao;
        produtoEncontrado.Preco = produto.Preco;
        produtoEncontrado.EntregaExpressa = produto.EntregaExpressa;
        produtoEncontrado.DataCadastro = produto.DataCadastro;
        produtoEncontrado.ImagemUrl = produto.ImagemUrl;
    }

    public void Excluir(int id)
    {
        var produtoEncontrado = Obter(id);
        _produtos.Remove(produtoEncontrado);
    }
}

