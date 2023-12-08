using MaterialDeContrucaoAppWeb.Models;
using MaterialDeContrucaoAppWeb.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;

namespace MaterialDeContrucaoAppWeb.Pages
{
    [Authorize]
    public class IncluirModel : PageModel
    {
        public SelectList MarcaOptionItems { get; set; }
        public SelectList CategoriaOptionItems { get; set; }
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

            CategoriaOptionItems = new SelectList(_service.ObterTodasCategorias(),
                                    nameof(Categoria.CategoriaId),
                                    nameof(Categoria.Descricao));
        }

        [BindProperty]
        public Produto Produto { get; set; }

        [BindProperty]
        public IList<int> CategoriaIds { get; set; }

        public IActionResult OnPost()
        {
            Produto.Categorias = _service.ObterTodasCategorias()
                                            .Where(item => CategoriaIds.Contains(item.CategoriaId))
                                            .ToList();

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
