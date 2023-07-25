using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityMetrolGagesCalibration
    {
        public int IdCalibracion { get; set; }
        public int? GageId { get; set; }
        public int? Intervalo { get; set; }
        public DateTime? FechaCalibracionAnterior { get; set; }
        public DateTime? FechaCalibracion { get; set; }
        public DateTime? FechaCalibracionSiguiente { get; set; }
        public int? UsuarioCalibradoId { get; set; }
        public int? ProveedorCalibradoId { get; set; }
        public string Resultado { get; set; }
        public string Comentarios { get; set; }
        public int? UsuarioRegistroId { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public bool? Status { get; set; }
    }
}
