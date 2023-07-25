using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class CorrectiveActionViewModel
    {
        public List<SelectListItem> Quality_CA_Tools { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Quality_CA_Sources { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Production_Departments { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Quality_CA_Responsible { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Quality_CA_Activity { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Quality_CA_CategoryAccion { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Quality_Processes { get; set; } = new List<SelectListItem>();
    }
}
