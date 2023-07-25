using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models
{
    public class CA_ResponsiblesManagements_CP
    {
        [Key]
        public int? UsuarioID  {get; set;}
        public string? NoEmpleado { get; set;}

        public string? Empleado     {get; set;}
        public int? ID_Gerencia { get; set; }
    }
}
