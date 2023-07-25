using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityAuditsAuditMatrixAbilities
    {
        public int IdRegistroHabilidades { get; set; }
        public int? AuditPlannerId { get; set; }
        public int? EstacionId { get; set; }
        public int? EmpleadoId { get; set; }
        public string Resultado { get; set; }
        public int? SupervisorId { get; set; }
        public string Comentario { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? UsusarioRegistroId { get; set; }
        public bool? Status { get; set; }
    }
}
