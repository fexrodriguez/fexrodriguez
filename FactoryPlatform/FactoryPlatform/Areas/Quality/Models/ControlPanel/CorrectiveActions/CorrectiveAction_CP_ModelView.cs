using FactoryPlatform.Areas.Quality.Models.ControlPanel.CorrectiveActions;
using FactoryPlatform.Areas.ServiceNow.Models.ServiceMenu.CorrectiveAction;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FactoryPlatform.Areas.Quality.Models
{
    public class CorrectiveAction_CP_ModelView
    {
        public int? IdSeccion { get; set; }
        public string TituloSeccion { get; set; }
        public int? Tipo { get; set; }

        public List<CA_Responsible_CP> CA_Responsible_CP { get; set; } = new List<CA_Responsible_CP>();
        public List<CA_ResponsiblesManagements_CP> CA_ResponsiblesManagements_CP { get; set; } = new List<CA_ResponsiblesManagements_CP>();
        public List<SelectListItem> Managements { get; set; } = new List<SelectListItem>();

        public List<CA_Responsible_CP> CA_Responsible_Closers_CP { get; set; } = new List<CA_Responsible_CP>();
        public List<SelectOptionsCA> Quality_CA_Sources { get; set; } = new List<SelectOptionsCA>();
        public List<SelectOptionsCA> Quality_CA_TypeSolutions { get; set; } = new List<SelectOptionsCA>();
        public List<Quality_Processes_CP> Quality_CA_Processes { get; set; } = new List<Quality_Processes_CP>();



    }
}
