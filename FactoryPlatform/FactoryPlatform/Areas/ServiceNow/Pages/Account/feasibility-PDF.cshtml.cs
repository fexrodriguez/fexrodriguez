using FactoryPlatform.Areas.ServiceNow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;

namespace FactoryPlatform.Areas.ServiceNow.Pages.Account
{
    public class feasibilityPDFModel : PageModel
    {
        public static String _dataFeasibility;  

        [BindProperty]
        public DigitalDocumentsFeasibilityModel Feasibility { get; set; }

        public void OnGet()
        {
            String data = _dataFeasibility;
            _dataFeasibility = null;

            if (data != null)
            {
                Feasibility = JsonConvert.DeserializeObject<DigitalDocumentsFeasibilityModel>(data);
            }
        }
    }
}
