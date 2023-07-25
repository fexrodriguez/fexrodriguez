using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityMetrolGagesStations
    {
        public int IdRegistro { get; set; }
        public int? GageId { get; set; }
        public int? EstacionId { get; set; }
        public int? EstacionNuevaId { get; set; }
        public string LocacionId { get; set; }
        public string LocacionNuevaId { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? UsuarioRegistroId { get; set; }
        public string Razon { get; set; }
        public string Comentarios { get; set; }
        public bool? Status { get; set; }
    }
}
