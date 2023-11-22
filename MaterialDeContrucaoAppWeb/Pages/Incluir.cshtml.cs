using MaterialDeContrucaoAppWeb.Models;
using MaterialDeContrucaoAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MaterialDeContrucaoAppWeb.Pages
{
    public class IncluirModel : PageModel
    {
        public SelectList MarcaOptionItems { get; set; }
        private IServiceProduto _service;

        public IncluirModel(IServiceProduto service)
        {
            _service = service;
        }

        public void OnGet()
        {
            MarcaOptionItems = new SelectList(_service.ObterTodasMarcas(),
                                                nameof(Marca.MarcaId),
                                                nameof(Marca.Descricao));
        }

        [BindProperty]
        public Produto Produto { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //inclusão
            _service.Incluir(Produto);

            TempData["TempMensagemSucesso"] = true;

            return RedirectToPage("/Index");
        }
    }
}
