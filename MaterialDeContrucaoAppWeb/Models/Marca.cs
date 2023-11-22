
namespace MaterialDeContrucaoAppWeb.Models;

public class Marca
{
    public int MarcaId { get; set; }
    public string Descricao { get; set;}

    public ICollection<Produto> Produtos { get; set;}
}
