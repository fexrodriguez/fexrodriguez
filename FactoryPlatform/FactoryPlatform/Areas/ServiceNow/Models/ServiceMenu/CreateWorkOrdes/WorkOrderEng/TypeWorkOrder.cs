using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class TypeWorkOrder
    {
        [Key]
        public int ID_Tipo { get; set; }
        public string TipoOrdenTrabajo { get; set; }
    }
}
