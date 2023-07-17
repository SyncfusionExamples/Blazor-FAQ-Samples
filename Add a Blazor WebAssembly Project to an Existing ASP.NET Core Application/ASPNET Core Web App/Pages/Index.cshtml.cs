using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNET_Core_Web_App.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel ( ILogger<IndexModel> logger )
        {
            _logger = logger;
        }

        public void OnGet ()
        {

        }
    }
}