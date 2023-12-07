using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MaterialDeContrucaoAppWeb.Data;
using MaterialDeContrucaoAppWeb.Models;

namespace MaterialDeContrucaoAppWeb.Pages.Categorias
{
    public class CreateModel : PageModel
    {
        private readonly MaterialDeContrucaoAppWeb.Data.MatConstDBContext _context;

        public CreateModel(MaterialDeContrucaoAppWeb.Data.MatConstDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Categoria Categoria { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Categorias == null || Categoria == null)
            {
                return Page();
            }

            _context.Categorias.Add(Categoria);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
