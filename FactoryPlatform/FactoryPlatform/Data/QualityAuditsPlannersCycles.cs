using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityAuditsPlannersCycles
    {
        public int IdCicloAuditoria { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? UsuarioCierreId { get; set; }
        public bool? Status { get; set; }
    }
}
