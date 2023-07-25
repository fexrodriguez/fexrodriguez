using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class Production_Departments
    {
        [Key]
        public int ID_Departamento { get; set; }
        public string Descripcion { get; set; }
        public int? ID_Estacion { get; set; }
        public int? PlantaID { get; set; }
    }
}
