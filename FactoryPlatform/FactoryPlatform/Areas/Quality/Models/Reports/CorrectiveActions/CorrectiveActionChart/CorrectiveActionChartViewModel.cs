using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FactoryPlatform.Areas.Quality.Models.Reports.CorrectiveActions.CorrectiveActionChart
{
    public class CorrectiveActionChartViewModel
    {
        public int? IdSeccion { get; set; }
        public string TituloSeccion { get; set; }
        public int? Tipo { get; set; }

        public List<SelectListItem> FilterOptions { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Status { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Rangers { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Quality_CA_Sources { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Quality_CA_Tools { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Quality_CA_Responsible { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> ClosersUsers { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Managements { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Quality_CA_CategoryAccion { get; set; } = new List<SelectListItem>();
        
    }
}
