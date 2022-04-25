using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeHub.Pages
{
    public class Python3Model : PageModel
    {
        private readonly ILogger<Python3Model> _logger;

        public Python3Model(ILogger<Python3Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}