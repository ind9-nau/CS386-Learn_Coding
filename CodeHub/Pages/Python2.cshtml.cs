using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeHub.Pages
{
    public class Python2Model : PageModel
    {
        private readonly ILogger<Python2Model> _logger;

        public Python2Model(ILogger<Python2Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}