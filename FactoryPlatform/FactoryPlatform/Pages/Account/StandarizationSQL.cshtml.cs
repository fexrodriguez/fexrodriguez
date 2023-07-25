using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FactoryPlatform.Pages.Account
{
    [Authorize]
    public class StandarizationSQLModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
