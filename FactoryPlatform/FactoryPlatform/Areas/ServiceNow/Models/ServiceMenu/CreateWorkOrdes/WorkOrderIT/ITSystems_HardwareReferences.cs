using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class ITSystems_HardwareReferences
    {
        [Key]
        public int ID_Referencia { get; set; }
        public string DescripcionReferencia { get; set; }
        public int EstacionID { get; set; }
    }
}
