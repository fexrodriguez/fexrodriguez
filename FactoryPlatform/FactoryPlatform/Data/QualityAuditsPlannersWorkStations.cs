using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityAuditsPlannersWorkStations
    {
        public int IdPlanner { get; set; }
        public int? CicloAuditoriaId { get; set; }
        public int? LineaId { get; set; }
        public int? EstacionId { get; set; }
        public int? UsuarioInspectorId { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFinal { get; set; }
        public bool? Modifica { get; set; }
        public int? UsuarioAsignoId { get; set; }
        public DateTime? FechaAsignado { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public bool? Status { get; set; }
    }
}
