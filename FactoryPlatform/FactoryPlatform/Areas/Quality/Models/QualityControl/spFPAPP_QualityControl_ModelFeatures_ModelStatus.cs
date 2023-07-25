using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models
{
    public class spFPAPP_QualityControl_ModelFeatures_ModelStatus
    {
        [Key]
        public int ID { get; set; }
        public string? Respuesta { get; set; }
        public int? QTY { get; set; }
        public string? Comentario { get; set; }
    }
}
