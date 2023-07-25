using FactoryPlatform.Areas.ServiceNow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FactoryPlatform.Areas.ServiceNow.Pages.Account
{
    public class deviationPDFModel : PageModel
    {
        public static String _dataDesviation;

        [BindProperty]
        public DigitalDocumentsDesviationModel Desviations { get; set; }

        public void OnGet()
        {
            String data = _dataDesviation;
            _dataDesviation = null;

            if (data != null)
            {
                Desviations = JsonConvert.DeserializeObject<DigitalDocumentsDesviationModel>(data);
            }
        }
    }
}
