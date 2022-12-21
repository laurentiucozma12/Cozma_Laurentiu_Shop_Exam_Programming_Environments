using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PlanteeaShop.Pages
{
    public class CopyrightModel : PageModel
    {
        private readonly ILogger<CopyrightModel> _logger;

        public CopyrightModel(ILogger<CopyrightModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}