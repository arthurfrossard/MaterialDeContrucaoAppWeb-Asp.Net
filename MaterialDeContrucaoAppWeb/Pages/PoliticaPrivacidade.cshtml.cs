using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MaterialDeContrucaoAppWeb.Pages
{
    public class PoliticaPrivacidade : PageModel
    {
        private readonly ILogger<PoliticaPrivacidade> _logger;

        public PoliticaPrivacidade(ILogger<PoliticaPrivacidade> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}