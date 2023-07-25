using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models
{
    public class CA_List_Combos
    {
        [Key]
        public int? Id_Registro {get; set;}
        public string? Valor   {get; set;}
        public int? Tipo{get; set;}
        public string? Opcion { get; set; } 
    }
}
