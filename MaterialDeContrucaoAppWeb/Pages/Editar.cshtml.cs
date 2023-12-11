using MaterialDeContrucaoAppWeb.Models;
using MaterialDeContrucaoAppWeb.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using System.Globalization;

namespace MaterialDeContrucaoAppWeb.Pages
{
    [Authorize]
    public class EditarModel : PageModel
    {
        public SelectList MarcaOptionItems { get; set; }
        public SelectList CategoriaOptionItems { get; set; }
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

        [BindProperty]
        public IList<int> CategoriaIds { get; set; }

        public IActionResult OnGet(int id)
        {
            Produto = _service.Obter(id);

            CategoriaIds = Produto.Categorias.Select(item => item.CategoriaId).ToList();

            MarcaOptionItems = new SelectList(_service.ObterTodasMarcas(),
                                               nameof(Marca.MarcaId),
                                               nameof(Marca.Descricao));

            CategoriaOptionItems = new SelectList(_service.ObterTodasCategorias(),
                                    nameof(Categoria.CategoriaId),
                                    nameof(Categoria.Descricao));

            if (Produto == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {

            Produto.Categorias = _service.ObterTodasCategorias()
                                            .Where(item => CategoriaIds.Contains(item.CategoriaId))
                                            .ToList();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (!double.TryParse(Request.Form["Produto.Preco"], NumberStyles.Any, CultureInfo.InvariantCulture, out double preco))
            {
                ModelState.AddModelError("Produto.Preco", "Formato inválido para o campo de preço.");
                return Page();
            }

            Produto.Preco = preco;

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

