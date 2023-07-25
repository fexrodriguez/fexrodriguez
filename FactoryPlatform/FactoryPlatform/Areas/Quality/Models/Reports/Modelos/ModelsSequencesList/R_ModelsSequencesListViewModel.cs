using System.Collections.Generic;

namespace FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelsSequencesList
{
    public class R_ModelsSequencesListViewModel
    {
        public int? IdSeccion { get; set; }
        public string TituloSeccion { get; set; }
        public int? Tipo { get; set; }

        public List<R_Secuence> R_Secuence { get; set; } = new List<R_Secuence>();
    }
}
