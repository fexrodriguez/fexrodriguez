using FactoryPlatform.Areas.ServiceNow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;

namespace FactoryPlatform.Areas.ServiceNow.Pages.Account
{
    public class toolListPDFModel : PageModel
    {
        public static String _dataToolList;

        [BindProperty]
        public DigitalDocumentsToolListModel ToolList { get; set; }

        public void OnGet()
        {
            String data = _dataToolList;
            _dataToolList = null;

            if (data != null)
            {
                ToolList = JsonConvert.DeserializeObject<DigitalDocumentsToolListModel>(data);
            }
        }
    }
}
