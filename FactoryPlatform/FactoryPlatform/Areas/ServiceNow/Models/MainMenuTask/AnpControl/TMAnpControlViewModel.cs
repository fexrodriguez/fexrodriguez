using FactoryPlatform.Areas.ServiceNow.Models.MainMenuTask.AnpControl;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class TMAnpControlViewModel
    {
        public List<ReportAnpControl> ReportAnpControl { get; set; } = new List<ReportAnpControl>();
        public List<SelectListItem> AnpListUsers { get; set; } = new List<SelectListItem>();
		public List<SelectListItem> AnpListReasingUsers { get; set; } = new List<SelectListItem>();
		public List<SelectListItem> AnpListUnits { get; set; } = new List<SelectListItem>();
		
		public int? Id_Usuario { get; set; }
    }
}
