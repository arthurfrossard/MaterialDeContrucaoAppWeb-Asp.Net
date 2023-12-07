using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MaterialDeContrucaoAppWeb.Data;
using MaterialDeContrucaoAppWeb.Models;

namespace MaterialDeContrucaoAppWeb.Pages.Marcas
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
        public Marca Marca { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Marcas == null || Marca == null)
            {
                return Page();
            }

            _context.Marcas.Add(Marca);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
