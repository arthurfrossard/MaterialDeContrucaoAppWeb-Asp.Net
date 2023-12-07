using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MaterialDeContrucaoAppWeb.Data;
using MaterialDeContrucaoAppWeb.Models;

namespace MaterialDeContrucaoAppWeb.Pages.Marcas
{
    public class DetailsModel : PageModel
    {
        private readonly MaterialDeContrucaoAppWeb.Data.MatConstDBContext _context;

        public DetailsModel(MaterialDeContrucaoAppWeb.Data.MatConstDBContext context)
        {
            _context = context;
        }

      public Marca Marca { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Marcas == null)
            {
                return NotFound();
            }

            var marca = await _context.Marcas.FirstOrDefaultAsync(m => m.MarcaId == id);
            if (marca == null)
            {
                return NotFound();
            }
            else 
            {
                Marca = marca;
            }
            return Page();
        }
    }
}
