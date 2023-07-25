using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityAuditsAuditsOpen
    {
        public int IdRegistro { get; set; }
        public int AuditoriaId { get; set; }
        public int LineaId { get; set; }
        public int TipoAuditoriaId { get; set; }
        public bool? Status { get; set; }
        public bool Run { get; set; }
        public DateTime? FechaCierre { get; set; }
        public bool? StatusTemplate { get; set; }
    }
}
