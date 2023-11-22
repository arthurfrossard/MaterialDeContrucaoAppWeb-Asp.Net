using MaterialDeContrucaoAppWeb.Models;
using MaterialDeContrucaoAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MaterialDeContrucaoAppWeb.Pages
{
    public class EditarModel : PageModel
    {
        public SelectList MarcaOptionItems { get; set; }
        private IServiceProduto _service;

        public EditarModel(IServiceProduto service)
        {
            _service = service;
        }

        [BindProperty]
        public Produto Produto { get; set; }

        public IActionResult OnGet(int id)
        {
            Produto = _service.Obter(id);

            MarcaOptionItems = new SelectList(_service.ObterTodasMarcas(),
                                               nameof(Marca.MarcaId),
                                               nameof(Marca.Descricao));

            if (Produto == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //alteração
            _service.Alterar(Produto);

            TempData["TempMensagemSucesso"] = true;

            return RedirectToPage("/Index");
        }

        public IActionResult OnPostExclusao()
        {
            //exclusão
            _service.Excluir(Produto.ProdutoId);

            TempData["TempMensagemSucesso"] = true;

            return RedirectToPage("/Index");
        }
    }
}

