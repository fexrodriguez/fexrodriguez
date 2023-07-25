using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityPerformanceReportsWarranty
    {
        public int IdRegistro { get; set; }
        public string NumeroSerie { get; set; }
        public DateTime FechaReclamo { get; set; }
        public string NumeroReclamo { get; set; }
        public string CodigoReclamo { get; set; }
        public string MillasInstalacion { get; set; }
        public string MillasFalla { get; set; }
        public DateTime FechaInstalacion { get; set; }
        public DateTime FechaFalla { get; set; }
        public string ReclamoVin { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public DateTime FechaInspeccion { get; set; }
        public string NombreInspector { get; set; }
        public string CodigoFalla { get; set; }
        public double DolaresAprovados { get; set; }
        public double DolaresNegados { get; set; }
        public string CargaFabrica { get; set; }
        public double CostoProducto { get; set; }
        public double CostoFlete { get; set; }
        public double ManoObra { get; set; }
        public double CostoFluido { get; set; }
        public DateTime FechaCierreReclamo { get; set; }
        public bool? Status { get; set; }
    }
}
