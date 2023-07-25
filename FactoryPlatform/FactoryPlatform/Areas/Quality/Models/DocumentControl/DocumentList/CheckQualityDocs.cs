using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models
{
    public class CheckQualityDocs
    {
        [Key]
        public int? ID_Documento {get; set;}
        public string? Status { get; set; }
    }
}
