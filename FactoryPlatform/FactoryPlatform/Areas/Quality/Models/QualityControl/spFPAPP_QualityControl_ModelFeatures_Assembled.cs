using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models
{
    public class spFPAPP_QualityControl_ModelFeatures_Assembled
    {
        [Key]
        public int ID_Registro { get; set; }
        public int? ID_Request { get; set; }
        public string? Codigo { get; set; }
        public string? DCodigo { get; set; }
        public string? Respuesta { get; set; }
    }
}
