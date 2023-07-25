using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DigitalDocumentsReleaseAnexB
    {
        [Key]
        public int ID_Registro { get; set; }
        public string? Preguntas { get; set; }
        public string? Resultado { get; set; }
        public string? Etapa { get; set; }
        public string? Comentario { get; set; }
        public string? Regulaciones { get; set; }
        public string? Autorizaciones { get; set; }
        public string? Planes { get; set; }
        public string? Infraestructura { get; set; }
        public byte? Tipo { get; set; }
    }
}
