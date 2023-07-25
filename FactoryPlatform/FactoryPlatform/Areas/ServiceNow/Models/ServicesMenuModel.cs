using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class ServicesMenuModel
    {
        [Key]
        public int? ID_MenuService { get; set; }
        public string? MenuSeccion{get; set;}
        public string? MenuIconos{get; set;}
        public bool? InMenu{get; set;}
        public string? Colors{get; set;}
        public string? FontColor{get; set;}
    }
}
