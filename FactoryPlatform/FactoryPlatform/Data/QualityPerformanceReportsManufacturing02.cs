using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityPerformanceReportsManufacturing02
    {
        public int IdRegistro { get; set; }
        public int PlantaFabricanteId { get; set; }
        public double Resultado { get; set; }
        public double Promedio { get; set; }
        public int MesRango { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int MesConsulta { get; set; }
        public int YearConsulta { get; set; }
        public bool? Status { get; set; }
    }
}
