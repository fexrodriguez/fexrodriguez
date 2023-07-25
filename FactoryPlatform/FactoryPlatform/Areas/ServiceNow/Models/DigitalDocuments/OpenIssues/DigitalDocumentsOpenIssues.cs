using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DigitalDocumentsOpenIssues
    {
        [Key]
        public int ID_Registro { get; set; }
        public string? Proyecto { get; set; }
        public string? NumeroParte { get; set; }
        public string? Lider { get; set; }
        public string? JobOrder { get; set; }
        public string? Name { get; set; }
    }
}
