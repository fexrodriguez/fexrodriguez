using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityMonitorRisksHistory
    {
        public int IdRegistro { get; set; }
        public int FactorId { get; set; }
        public int MesEvaluacion { get; set; }
        public int AnioEvaluacion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public string Comentario { get; set; }
    }
}
