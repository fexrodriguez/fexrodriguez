using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models.ControlPanel.CorrectiveActions
{
    public class Quality_Processes_CP
    {
        [Key]
        public int? ID_Proceso {get; set;}
        public int? Numero  {get; set;}
        public string? Descripcion { get; set; }
    }
}
