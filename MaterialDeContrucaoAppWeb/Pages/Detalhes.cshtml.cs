using MaterialDeContrucaoAppWeb.Models;
using MaterialDeContrucaoAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MaterialDeContrucaoAppWeb.Pages
{
    public class DetalhesModel : PageModel
    {
        private IServiceProduto _service;

        public DetalhesModel(IServiceProduto service) => _service = service;

        public Produto Produto { get; private set; }

        public IActionResult OnGet(int id)
        {
            Produto = _service.Obter(id);

            if (Produto == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
