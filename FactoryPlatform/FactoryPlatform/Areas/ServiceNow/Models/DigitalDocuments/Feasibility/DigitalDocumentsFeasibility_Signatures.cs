using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DigitalDocumentsFeasibility_Signatures
    {
        [Key]
        public int? ID_Registro { get; set; }
        public string? Signatures { get; set; }
    }
}
