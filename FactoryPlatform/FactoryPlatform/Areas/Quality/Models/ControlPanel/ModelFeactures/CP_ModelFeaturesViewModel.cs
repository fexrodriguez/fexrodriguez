using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FactoryPlatform.Areas.Quality.Models.ControlPanel.ModelFeactures
{
    public class CP_ModelFeaturesViewModel
    {
        public int? IdSeccion { get; set; }
        public string TituloSeccion { get; set; }
        public int? Tipo { get; set; }

        //===================================================================
        public string Modelo { get; set; }
        public int Estacion { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PlantaId { get; set; }


        public List<SelectListItem> Quality_Workstations { get; set; } = new List<SelectListItem>();
        public List<CP_Q_ModelFeature> CP_Q_ModelFeature { get; set; } = new List<CP_Q_ModelFeature>();
        public List<FilesModelFeactures> FilesModelFeactures { get; set; } = new List<FilesModelFeactures>();

    }
}
