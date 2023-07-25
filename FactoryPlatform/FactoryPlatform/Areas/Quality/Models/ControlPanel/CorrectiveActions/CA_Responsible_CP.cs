using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models
{
    public class CA_Responsible_CP
    {
        [Key]
        public int? ID_Usuario { get; set; }
        public string? Responsable { get; set; }
        public int? Seleccionado { get; set; }
    }
}
