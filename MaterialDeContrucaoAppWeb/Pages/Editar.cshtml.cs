using MaterialDeContrucaoAppWeb.Models;
using MaterialDeContrucaoAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;

namespace MaterialDeContrucaoAppWeb.Pages
{
    public class EditarModel : PageModel
    {
        public SelectList MarcaOptionItems { get; set; }
        private IServiceProduto _service;
        private IToastNotification _toastNotification;

        public EditarModel(IServiceProduto service,
                                IToastNotification toastNotification)
        {
            _service = service;
            _toastNotification = toastNotification;
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

            _toastNotification.AddSuccessToastMessage("Alteração de produto realizada com sucesso!");

            return RedirectToPage("/Index");
        }

        public IActionResult OnPostExclusao()
        {
            //exclusão
            _service.Excluir(Produto.ProdutoId);

            _toastNotification.AddSuccessToastMessage("Exclusão de produto realizada com sucesso!");

            return RedirectToPage("/Index");
        }
    }
}

