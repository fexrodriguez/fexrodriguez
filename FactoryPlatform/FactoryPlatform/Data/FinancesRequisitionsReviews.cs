using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class FinancesRequisitionsReviews
    {
        public int IdRegistro { get; set; }
        public int RequisicionId { get; set; }
        public int UsuarioAsignoId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioAsignadoId { get; set; }
        public DateTime? FechaLiberado { get; set; }
        public string Comentarios { get; set; }
        public int TiempoRespuesta { get; set; }
        public int Nivel { get; set; }
        public int Opcion { get; set; }
        public bool? Status { get; set; }
    }
}
