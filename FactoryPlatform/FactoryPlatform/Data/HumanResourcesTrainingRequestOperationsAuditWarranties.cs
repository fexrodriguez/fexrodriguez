using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesTrainingRequestOperationsAuditWarranties
    {
        public int IdRegistro { get; set; }
        public int SolicitudId { get; set; }
        public int AccionGarantiaId { get; set; }
        public string Resultado { get; set; }
        public string Comentario { get; set; }
        public string Alerta { get; set; }
        public DateTime? FechaRegistroContestado { get; set; }
        public bool? Status { get; set; }
    }
}
