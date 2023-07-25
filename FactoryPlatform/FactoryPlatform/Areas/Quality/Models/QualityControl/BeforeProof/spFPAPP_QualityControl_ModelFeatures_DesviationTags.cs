using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models
{
    public class spFPAPP_QualityControl_ModelFeatures_DesviationTags
    {
        [Key]
        public int RegistroDesviacionID { get; set; }
        public string? Desviacion { get; set; }
        public int? RequestID { get; set; }
        public string? Codigo { get; set; }
        public string? NombreProveedor { get; set; }
    }
}
