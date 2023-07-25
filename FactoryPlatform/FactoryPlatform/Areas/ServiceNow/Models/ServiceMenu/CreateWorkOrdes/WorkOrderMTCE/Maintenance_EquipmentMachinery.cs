using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class Maintenance_EquipmentMachinery
    {
        [Key]
        public int ID_Maquina { get; set; }
        public string DescripcionMaquina { get; set; }
        public int EstacionID { get; set; }
    }
}
