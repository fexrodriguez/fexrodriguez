using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityPerformanceIndicatorsConcepts
    {
        public int IdRegistro { get; set; }
        public int NumeroId { get; set; }
        public int DepartamentoId { get; set; }
        public int ProcesoId { get; set; }
        public int IndicadorId { get; set; }
        public double Meta { get; set; }
        public bool MetricRule { get; set; }
        public byte? Metric { get; set; }
        public bool Status { get; set; }
        public int PlantaId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
    }
}
