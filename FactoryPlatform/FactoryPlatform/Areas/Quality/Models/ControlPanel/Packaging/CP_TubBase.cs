using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models.ControlPanel.Packaging
{
    public class CP_TubBase 
    {
        [Key]
        public int? ID_Registro { get; set; }
        public string? Numero { get; set; }
        public string? Descripcion { get; set; }
        public string? FechaRegistro { get; set; }
        public string? UsuarioRegistro { get; set; }
        public bool? Locked { get; set; }
    }
}
