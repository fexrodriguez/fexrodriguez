using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models
{
    public class Keys_longitud
    {
        [Key]
        public int? ID { get; set; }
        public string? Tipo {get; set;}
        public byte? Longitud {get; set;}
    }
}
