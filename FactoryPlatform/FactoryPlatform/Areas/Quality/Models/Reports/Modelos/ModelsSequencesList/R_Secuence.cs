using FactoryPlatform.Data;
using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelsSequencesList
{
    public class R_Secuence
    {
        [Key]
        public int? ID_Registro {get; set;}
        public string? Modelo  {get; set;}
        public byte? Secuencia   {get; set;}
        public string? Descripcion { get; set; }
    }
}
