using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FactoryPlatform.Pages.Account
{
    [Authorize]
    public class PrivacyModel : PageModel
    {
        public void OnGet(string message)
        {
           ViewData["Message"] = message;   
        }
    }
}
