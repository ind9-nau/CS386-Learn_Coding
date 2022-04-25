using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeHub.Pages
{
    public class Python1Model : PageModel
    {
        private readonly ILogger<Python1Model> _logger;

        public Python1Model(ILogger<Python1Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}