using FactoryPlatform.Areas.ServiceNow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;

namespace FactoryPlatform.Areas.ServiceNow.Pages.Account
{
    public class amef_PDFModel : PageModel
    {
        public static String _dataAMEF;

        [BindProperty]
        public DigitalDocumentAMEF_Model AMEF { get; set; }
        public void OnGet()
        {
            String data = _dataAMEF;
            _dataAMEF = null;

            if (data != null)
            {
                AMEF = JsonConvert.DeserializeObject<DigitalDocumentAMEF_Model>(data);
            }
        }
    }
}
