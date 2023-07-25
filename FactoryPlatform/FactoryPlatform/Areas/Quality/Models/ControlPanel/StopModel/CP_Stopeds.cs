using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models.ControlPanel.StopModel
{
    public class CP_Stopeds
    {
        [Key]
        public int? ID_Registro { get; set; }
        public string? Modelo  {get; set;}
        public string? MensajeAlerta {get; set;}
        public string? UsuarioRegistro{get; set;}
    }
}
