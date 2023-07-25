using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityMonitorRisks
    {
        public int IdRegistro { get; set; }
        public string Factor { get; set; }
        public int? PestelId { get; set; }
        public byte Frecuencia { get; set; }
        public string Proceso { get; set; }
        public bool Tipo { get; set; }
        public bool? Status { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
    }
}
