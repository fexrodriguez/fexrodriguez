using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class MainMenuModel
    {
        [Key]
        public int? ID_MenuSeccion { get; set; }
        public string? MenuSeccion {get; set;}
        public string? MenuIconos{get; set;}
        public bool? InMenu{get; set;}
        public string? Color{get; set;}
        public string? ColorActivo{get; set;}
        public bool? Activo{get; set;}
    }
}
