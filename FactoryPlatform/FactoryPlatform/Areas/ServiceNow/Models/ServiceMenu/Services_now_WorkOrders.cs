using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class Services_now_WorkOrders
    {
        [Key]
        public int ID { get; set; }
        public string Correct { get; set; }
    }
}
