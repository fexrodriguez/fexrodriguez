using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FactoryPlatform.Areas.Quality.Models.ControlPanel.Modelos
{
    public class CP_ModelsModelView
    {
            public int? IdSeccion { get; set; }
            public string TituloSeccion { get; set; }
            public int? Tipo { get; set; }

        public List<CP_ModelsFamily> CP_Family { get; set; } = new List<CP_ModelsFamily>();
        public List<SelectListItem> Production_Cells { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Status { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Component { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Proof { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Packaging { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Huacal { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TUBPlastic { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TUBWood { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TUBLid { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TUBBase { get; set; } = new List<SelectListItem>();
    }
}
