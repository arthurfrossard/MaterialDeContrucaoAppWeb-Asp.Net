using MaterialDeContrucaoAppWeb.Models;

namespace MaterialDeContrucaoAppWeb.Services;

public interface IServiceProduto
{
    IList<Produto> ObterTodos();
    Produto Obter(int id);
    void Incluir(Produto produto);
    void Alterar(Produto produto);
    void Excluir(int id);
}