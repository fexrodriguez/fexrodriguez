using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models
{
    public class AffectedDocuments
    {
        [Key]
        public int? ID_Documento { get; set; }
        public string? Descripcion { get; set; }
    }
}
