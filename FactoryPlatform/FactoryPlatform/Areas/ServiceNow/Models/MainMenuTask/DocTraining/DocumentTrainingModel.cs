using System;
using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DocumentTrainingModel
    {
        [Key]
        public int ID_Documento { get; set; }
        public string Clave { get; set; }
        public string DescDoc { get; set; }
        public string DescDT { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public int DiasTranscurridos { get; set; }
        public string? TipoArchivo { get; set; }
        public int? DigitalID { get; set; }
        public byte? TipoDigital { get; set; }
        public string? Ruta { get; set; }
    }
}
