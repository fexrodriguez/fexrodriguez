using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelFeatureList
{
    public class R_ModelFeatureList
    {
        [Key]
        public int? ID_Registro { get; set; }
        public string? Modelo { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public string? FechaRegistro { get; set; }
        public int? Orden { get; set; }
        public int? EstacionID { get; set; }
        public string? Personal { get; set; }
        public string? Estacion { get; set; }

    }
}
