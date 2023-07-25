using System;
using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DigitalDocumentsOpenIssues_Hallazgo
    {
        [Key]
        public string Hallazgo { get; set; }
        public string? FechaDeteccion { get; set; }
        public byte? SeveridadID { get; set; }
        public string? Severidad { get; set; }
        public string? Descripcion { get; set; }
        public string? Responsable { get; set; }
        public string? Tipo { get; set; }
        public string? Dpto { get; set; }
        public string? Accion { get; set; }
        public string? FechaCierre { get; set; }
        public int? Status { get; set; }
        public string? AccionCorrectiva { get; set; }
    }
}
