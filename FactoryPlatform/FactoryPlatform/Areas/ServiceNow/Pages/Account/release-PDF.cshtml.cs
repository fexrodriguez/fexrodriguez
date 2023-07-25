using FactoryPlatform.Areas.ServiceNow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;

namespace FactoryPlatform.Areas.ServiceNow.Pages.Account
{
    public class release_PDFModel : PageModel
    {
        public static String _dataRelease;
        [BindProperty(SupportsGet = true)]
        public DigitalDocumentsReleaseModel Release { get; set; }

        public void OnGet()
        {
            String data = _dataRelease;
            _dataRelease = null;

            if (data != null)
            {
                Release = JsonConvert.DeserializeObject<DigitalDocumentsReleaseModel>(data);
            }

        }
    }
}
