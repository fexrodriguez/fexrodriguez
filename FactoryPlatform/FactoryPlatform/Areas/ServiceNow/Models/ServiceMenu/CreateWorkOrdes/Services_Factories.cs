using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class Services_Factories
    {
        [Key]
        public int ID_Planta { get; set; }
        public string Descripcion { get; set; }
    }
}
