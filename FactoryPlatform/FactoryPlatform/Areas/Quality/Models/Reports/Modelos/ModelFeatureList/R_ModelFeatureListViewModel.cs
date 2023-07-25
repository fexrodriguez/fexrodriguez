using FactoryPlatform.Areas.Quality.Models.ControlPanel.Modelos;
using System.Collections.Generic;

namespace FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelFeatureList
{
    public class R_ModelFeatureListViewModel
    {
        public int? IdSeccion { get; set; }
        public string TituloSeccion { get; set; }
        public int? Tipo { get; set; }
        public int? EstacionID { get; set; }
        public int? EmployeeID { get; set; }

        public List<SelectOptionsModels> WorkStation { get; set; } = new List<SelectOptionsModels>();
        public List<SelectOptionsModels> Employees { get; set; } = new List<SelectOptionsModels>();
        public List<R_ModelFeatureList> R_ModelFeatureList { get; set; } = new List<R_ModelFeatureList>();


    }
}
