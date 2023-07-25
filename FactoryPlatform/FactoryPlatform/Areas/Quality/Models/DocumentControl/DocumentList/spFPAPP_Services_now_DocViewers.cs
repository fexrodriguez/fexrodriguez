using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models
{
    public class spFPAPP_Services_now_DocViewers
    {
        [Key]
        public int ID { get; set; }
        public string? Clave { get; set; }
        public int? Revision { get; set; }
        public int? Respuesta { get; set; }
    }
}
