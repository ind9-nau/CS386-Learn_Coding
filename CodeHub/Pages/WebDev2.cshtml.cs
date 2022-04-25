using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeHub.Pages
{
    public class WebDev2Model : PageModel
    {
        private readonly ILogger<WebDev2Model> _logger;

        public WebDev2Model(ILogger<WebDev2Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}