using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DigitalDocumentsReleaseQuestions
    {
        [Key]
        public int ID_Registro { get; set; }
        public string? Preguntas { get; set; }
        public byte? Tipo { get; set; }
        public string? Cumple { get; set; }
        public string? Comentario { get; set; }
    }
}
