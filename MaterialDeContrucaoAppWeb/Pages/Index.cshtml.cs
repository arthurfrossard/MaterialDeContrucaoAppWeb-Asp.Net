using MaterialDeContrucaoAppWeb.Models;
using MaterialDeContrucaoAppWeb.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MaterialDeContrucaoAppWeb.Pages;

public class IndexModel : PageModel
{
    private IServiceProduto _service;

    public IndexModel(IServiceProduto service)
    {
        _service = service;
    }

    public IList<Produto> ListaProduto { get; private set; }

    public void OnGet()
    {
        ViewData["Title"] = "Home page";

        ListaProduto = _service.ObterTodos();
    }
}
