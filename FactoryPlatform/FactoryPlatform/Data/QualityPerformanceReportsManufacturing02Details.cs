using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityPerformanceReportsManufacturing02Details
    {
        public int IdRegistro { get; set; }
        public int FabricanteId { get; set; }
        public int Mes { get; set; }
        public int YearId { get; set; }
        public int Produccion { get; set; }
        public int Ventas { get; set; }
        public double PorcentajeVentas { get; set; }
        public int Claims90 { get; set; }
        public double PorcentajeClaims90 { get; set; }
        public double Promedio36 { get; set; }
        public double Promedio12 { get; set; }
        public double Goal { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool? Status { get; set; }
    }
}
