using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class ProductionMissingItemsReviews
    {
        public int IdRegistro { get; set; }
        public int? FaltanteId { get; set; }
        public int UsuarioRevisionId { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int UsuarioAsignadoId { get; set; }
        public DateTime? FechaLiberado { get; set; }
        public int? TiempoRespuesta { get; set; }
        public string Comentarios { get; set; }
        public bool? Status { get; set; }
    }
}
