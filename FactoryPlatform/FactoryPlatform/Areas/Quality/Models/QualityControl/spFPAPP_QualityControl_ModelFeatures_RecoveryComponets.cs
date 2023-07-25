using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models
{
    public class spFPAPP_QualityControl_ModelFeatures_RecoveryComponets
    {
        [Key]
        public int ID_Registro { get; set; }
        public int? ModeloID { get; set; }
        public int? ComponenteID { get; set; }
        public string? Componente { get; set; }
        public string? Modelo { get; set; }
        public string? Descripcion { get; set; }
        public string Respuesta { get; set; }
    }
}
