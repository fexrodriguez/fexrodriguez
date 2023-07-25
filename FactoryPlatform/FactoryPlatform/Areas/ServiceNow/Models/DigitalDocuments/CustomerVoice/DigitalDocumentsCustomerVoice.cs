using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DigitalDocumentsCustomerVoice
    {
        [Key]
        public int? ID_Registro { get; set; }
        public string? Question { get; set; }
        public byte? Tipo { get; set; }
        public bool? Producto { get; set; }
        public bool? Proceso { get; set; }
        public string? Detalle { get; set; }
        public string? Tquestion { get; set; }
    }
}
