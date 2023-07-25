using FactoryPlatform.Data;
using System.Collections.Generic;

namespace FactoryPlatform.Areas.Quality.Models
{
    public class BeforeProofViewModel
    {
        public List<QualityModelFeatures> QualityModelFeatures { get; set; }
        public List<spFPAPP_QualityControl_ModelFeatures_DesviationTags> DesviationTags { get; set; }
        public List<FilesModelFeactures> FilesModelFeactures { get; set; } = new List<FilesModelFeactures>();

        public string TituloSeccion { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public int? IdSeccion { get; set; }
        public int? Tipo { get; set; }
        public int? Station { get; set; }
    }
}
