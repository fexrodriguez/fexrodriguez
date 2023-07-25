using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FactoryPlatform.Areas.Quality.Models
{
    public class spFPAPP_QualityControl_ModelFeatures_ValidationMissingAssamble
    {
        [Key]
        public int ID { get; set; }
        public int Ensamble1 { get; set; }
        public int Ensamble2 { get; set; }
        public int Ensamble3 { get; set; }
        public int Ensamble4 { get; set; }
        public int Ensamble5 { get; set; }
        public int Ensamble6 { get; set; }
        public int Lavado { get; set; }
        public string Respuesta { get; set; }
        public int Caracteristica { get; set; }
    }
}
