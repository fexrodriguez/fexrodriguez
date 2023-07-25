using FactoryPlatform.Areas.ServiceNow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;

namespace FactoryPlatform.Areas.ServiceNow.Pages.Account
{
    public class anpPDFModel : PageModel
    {
        public static String _dataANP;

        [BindProperty]
        public DigitalDocumentsANPModel ANP { get; set; }

        public void OnGet()
        {
            String data = _dataANP;
            _dataANP = null;

            if (data != null)
            {
                ANP = JsonConvert.DeserializeObject<DigitalDocumentsANPModel>(data);
            }
        }
    }
}
