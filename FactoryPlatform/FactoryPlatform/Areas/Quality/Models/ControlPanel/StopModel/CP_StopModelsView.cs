using System.Collections.Generic;

namespace FactoryPlatform.Areas.Quality.Models.ControlPanel.StopModel
{
    public class CP_StopModelsView
    {
        public int? IdSeccion { get; set; }
        public string TituloSeccion { get; set; }
        public int? Tipo { get; set; }

        public List<CP_Stopeds> CP_Stopeds { get; set; } = new List<CP_Stopeds>();

    }
}
