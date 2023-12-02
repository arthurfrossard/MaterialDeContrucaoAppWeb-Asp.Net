using System.ComponentModel.DataAnnotations;

namespace MaterialDeContrucaoAppWeb.Models;

public class Produto
{
    public int ProdutoId { get; set; }

    [Required(ErrorMessage = "Campo 'Nome' obrigatório.")]
    [StringLength(50, MinimumLength = 5, ErrorMessage = "Campo 'Nome' deve ter entre 5 e 50 caracteres.")]
    public string Nome { get; set; }
    public string NomeSlug => Nome.ToLower().Replace(" ", "-");

    [Required(ErrorMessage = "Campo 'Descrição' obrigatório.")]
    [StringLength(200, MinimumLength = 10, ErrorMessage = "Campo 'Descrição' deve ter entre 10 e 200 caracteres.")]
    [Display(Name = "Descrição")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "Campo 'Caminho URL da imagem' obrigatório.")]
    [Display(Name = "Caminho URL da imagem")]
    public string ImagemUrl { get; set; }

    [Required(ErrorMessage = "Campo 'Preço' obrigatório.")]
    [Display(Name = "Preço")]
    [DataType(DataType.Currency)]
    public double Preco { get; set; }

    [Display(Name = "Disponibilidade Estoque")]
    public bool DisponibilidadeEstoque { get; set; }

    public string DisponibilidadeEstoqueFormatada => DisponibilidadeEstoque ? "Sim" : "Não";

    [Required(ErrorMessage = "Campo 'Disponível em' obrigatório.")]
    [Display(Name = "Disponível em")]
    [DisplayFormat(DataFormatString = "{0:MMMM \\de yyyy}")]
    [DataType("month")]
    public DateTime DataCadastro { get; set; }

    [Display(Name = "Marca")]
    public int? MarcaId { get; set; }

    [Display(Name = "Categoria")]
    public ICollection<Categoria>? Categorias { get; set; }
}
