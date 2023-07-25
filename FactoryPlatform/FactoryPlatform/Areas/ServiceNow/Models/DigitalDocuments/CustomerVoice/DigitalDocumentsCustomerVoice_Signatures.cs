using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DigitalDocumentsCustomerVoice_Signatures
    {
        [Key]
        public int ID_Registro { get; set; }
        public string? Ing { get; set; }
        public string? Proyecto { get; set; }
        public string? Fecha { get; set; }
        public byte? TipoDoc { get; set; }
        public string? Comments { get; set; }
        public int? DocumentoID { get; set; }
        public string? NumeroParte { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerOrg { get; set; }    
        public string? Firmas { get; set; }
        public string? Componente { get; set; }
        public int? PlantaID  { get; set; }
    }
}
