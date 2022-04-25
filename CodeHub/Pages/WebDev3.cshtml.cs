using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeHub.Pages
{
    public class WebDev3Model : PageModel
    {
        private readonly ILogger<WebDev3Model> _logger;

        public WebDev3Model(ILogger<WebDev3Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}