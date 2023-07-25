using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class LogisticsMarchingReportCoreConversion
    {
        public int IdRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int MotorId { get; set; }
        public string CoreOrigen { get; set; }
        public string CoreDestino { get; set; }
        public byte Tipo { get; set; }
        public string Componente { get; set; }
        public int? IdRelacion { get; set; }
    }
}
