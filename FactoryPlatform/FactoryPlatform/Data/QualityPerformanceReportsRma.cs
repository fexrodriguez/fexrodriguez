using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityPerformanceReportsRma
    {
        public int IdRegistro { get; set; }
        public string NumeroSerie { get; set; }
        public DateTime? FechaRma { get; set; }
        public string NumeroRma { get; set; }
        public DateTime? FechaRecibiso { get; set; }
        public string TipoRma { get; set; }
        public string Descripcion { get; set; }
    }
}
