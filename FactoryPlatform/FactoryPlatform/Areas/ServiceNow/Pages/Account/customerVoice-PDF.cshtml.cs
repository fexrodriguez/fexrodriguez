using FactoryPlatform.Areas.ServiceNow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;

namespace FactoryPlatform.Areas.ServiceNow.Pages.Account
{
    public class customerVoice_PDFModel : PageModel
    {
        public static String _dataCustomerVoice;

        [BindProperty]
        public DigitalDocumentsCustomerVoiceModel CustomerVoice { get; set; }
        public void OnGet()
        {
            String data = _dataCustomerVoice;
            _dataCustomerVoice = null;

            if (data != null)
            {
                CustomerVoice = JsonConvert.DeserializeObject<DigitalDocumentsCustomerVoiceModel>(data);
            }
        }
    }
}
