using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models
{ 
    public class UsersReponsables
    {
        [Key]
        public int? ID_Usuario { get; set; }
        public string? Responsable { get; set; }
        public string? Puesto { get; set; }
        public int? Privilegio { get; set; }
    }
}
