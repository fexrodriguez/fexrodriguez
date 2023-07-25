using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DigitalDocumentsFeasibility
    {
        [Key]
        public int? ID_Registro { get; set; }
        public string? Ing { get; set; }
        public string? Proyecto { get; set; }
        public string? Fecha { get; set; }
        public byte? Conclusion { get; set; }
        public string? Comments { get; set; }
        public byte? Status { get; set; }
        public int? TipoDoc { get; set; }
        public string? Question { get; set; }
        public bool? Opcion { get; set; }
        public byte? Tipo { get; set; }
        public int? DocumentoID { get; set; }
    }
}
