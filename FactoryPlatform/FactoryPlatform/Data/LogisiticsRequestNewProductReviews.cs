using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class LogisiticsRequestNewProductReviews
    {
        public int IdRegistro { get; set; }
        public int RequestId { get; set; }
        public int UsuarioRevisionId { get; set; }
        public DateTime FechaRevision { get; set; }
        public string Tarea { get; set; }
        public string ComentarioRevision { get; set; }
        public int UsuarioAsignadoId { get; set; }
        public DateTime? FechaLiberado { get; set; }
        public int? TiempoRespuesta { get; set; }
        public string ComentarioLiberado { get; set; }
        public int Nivel { get; set; }
        public int Opcion { get; set; }
        public bool? Status { get; set; }
    }
}
