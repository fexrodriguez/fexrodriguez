using FactoryPlatform.Areas.ServiceNow.Models.PendingTask.CorrectiveActions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class TMCorrectiveActionViewModel
    {
        public List<TMReportCorrectiveAction> TMReportCorrectiveAction { get; set; } = new List<TMReportCorrectiveAction>();
        

        //Step 1
        public List<SelectListItem> Quality_CA_Sources { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Production_Departments { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Quality_Processes { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Quality_CA_Activity { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Quality_CA_CategoryAccion { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Quality_CA_Responsible { get; set; } = new List<SelectListItem>();

        //Step 3
        public List<SelectListItem> ClosersUsers { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> SolutionType { get; set; } = new List<SelectListItem>();

        public int UserID { get; set; }

    }
}
