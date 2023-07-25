using System;
using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DigitalDocumentsToolList
    {
        [Key]
        public int? Registro { get; set; }
        public int? OperacionID { get; set; }
        public string? Operaciones { get; set; }
        public string? Descripcion { get; set; }
        public string? Actividad { get; set; }
        public string? Codigo { get; set; }
        public string? Numero { get; set; }
        public string? Fecha { get; set; }
        public byte? StatusOperacion { get; set; }
        public string? Responsable { get; set; }
        public int? Tipo { get; set; }
    }
}
