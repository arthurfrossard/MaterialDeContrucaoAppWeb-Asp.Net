using MaterialDeContrucaoAppWeb.Models;
using MaterialDeContrucaoAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;

namespace MaterialDeContrucaoAppWeb.Pages
{
    public class IncluirModel : PageModel
    {
        public SelectList MarcaOptionItems { get; set; }
        private IServiceProduto _service;
        private IToastNotification _toastNotification;

        public IncluirModel(IServiceProduto service,
                                IToastNotification toastNotification)
        {
            _service = service;
            _toastNotification = toastNotification;
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

            _toastNotification.AddSuccessToastMessage("Inclusão de produto realizada com sucesso!");

            return RedirectToPage("/Index");
        }
    }
}
