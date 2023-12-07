using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MaterialDeContrucaoAppWeb.Data;
using MaterialDeContrucaoAppWeb.Models;

namespace MaterialDeContrucaoAppWeb.Pages.Categorias
{
    public class IndexModel : PageModel
    {
        private readonly MaterialDeContrucaoAppWeb.Data.MatConstDBContext _context;

        public IndexModel(MaterialDeContrucaoAppWeb.Data.MatConstDBContext context)
        {
            _context = context;
        }

        public IList<Categoria> Categoria { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Categorias != null)
            {
                Categoria = await _context.Categorias.ToListAsync();
            }
        }
    }
}
