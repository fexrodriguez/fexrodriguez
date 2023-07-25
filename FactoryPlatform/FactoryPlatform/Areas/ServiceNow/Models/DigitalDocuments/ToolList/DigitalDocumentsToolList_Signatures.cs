using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DigitalDocumentsToolList_Signatures
    {
        [Key]
        public int? ID_Registro { get; set; }
        public string? Firmas { get; set; }
        public string? Codigo { get; set; }
        public string? Registro { get; set; }
        public string? Componente { get; set; }
    }
}
