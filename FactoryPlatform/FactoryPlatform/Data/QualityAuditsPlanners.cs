using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityAuditsPlanners
    {
        public int IdAuditPlanner { get; set; }
        public int? LineaId { get; set; }
        public int? Turno { get; set; }
        public int? InspectorAsignadoId { get; set; }
        public DateTime? FechaAsignado { get; set; }
        public int? UsuarioAsignadoId { get; set; }
        public DateTime? FechaRegistrado { get; set; }
        public bool? Status { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioActualizacionId { get; set; }
        public byte? IncompletaId { get; set; }
        public DateTime? FechaTerminacion { get; set; }
    }
}
