using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models   
{
    public class Production_Stations
    {
        [Key]
        public int ID_Estacion { get; set; }
        public string Descripcion { get; set; }

    }
}
