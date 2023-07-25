using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class LogisticsMarchingReportResume
    {
        public int IdRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Planta { get; set; }
        public string Linea { get; set; }
        public string Abbreviation { get; set; }
        public int ReporteId { get; set; }
        public string CodigoAtk { get; set; }
        public double? ShortBy { get; set; }
        public double? Stock { get; set; }
        public double? Target { get; set; }
        public double? Porcentaje { get; set; }
        public double? OnOrder { get; set; }
        public double? BackOrder { get; set; }
        public double? Int { get; set; }
        public double? Vdm { get; set; }
        public double? F9 { get; set; }
        public double? WipJobs { get; set; }
        public double? JobsFirm { get; set; }
        public double? JobsTarget { get; set; }
        public double? ProdPace { get; set; }
        public double? Monday { get; set; }
        public double? Tuesday { get; set; }
        public double? Wednesday { get; set; }
        public double? Thursday { get; set; }
        public double? Friday { get; set; }
        public double? Saturday { get; set; }
        public double? Balancetobuild { get; set; }
        public string K70 { get; set; }
        public string Wip { get; set; }
        public string K10 { get; set; }
        public string K7 { get; set; }
        public string Cc { get; set; }
        public string Int1 { get; set; }
        public string F27 { get; set; }
        public string Best { get; set; }
    }
}
