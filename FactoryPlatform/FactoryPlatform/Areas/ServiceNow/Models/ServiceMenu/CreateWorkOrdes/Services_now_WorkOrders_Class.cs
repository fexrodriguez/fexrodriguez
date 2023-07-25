using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class Services_now_WorkOrders_Class
    {
        [Key]
        public int ID_Clase { get; set; }
        public string Clase { get; set; }
    }
}
