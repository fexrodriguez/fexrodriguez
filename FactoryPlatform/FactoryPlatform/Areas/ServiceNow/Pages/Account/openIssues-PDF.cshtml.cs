using FactoryPlatform.Areas.ServiceNow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;

namespace FactoryPlatform.Areas.ServiceNow.Pages.Account
{
    public class openIssues_PDFModel : PageModel
    {
        public static String _dataOpenIssues;

        [BindProperty]
        public DigitalDocumentsOpenIssuesModel OpenIssues { get; set; }

        public void OnGet()
        {
            String data = _dataOpenIssues;
            _dataOpenIssues = null;

            if (data != null)
            {
                OpenIssues = JsonConvert.DeserializeObject<DigitalDocumentsOpenIssuesModel>(data);
            }
        }
    }
}
