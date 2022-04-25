using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeHub.Pages
{
    public class WebDev1Model : PageModel
    {
        private readonly ILogger<WebDev1Model> _logger;

        public WebDev1Model(ILogger<WebDev1Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}