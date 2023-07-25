using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityPerformanceIndicators
    {
        public int IdIndicador { get; set; }
        public string NumeroIndicador { get; set; }
        public byte Departamento { get; set; }
        public string Proceso { get; set; }
        public string IndicadorDesempeno { get; set; }
        public DateTime MesIndicador { get; set; }
        public double MetaIndicador { get; set; }
        public double? RealIndicador { get; set; }
        public byte? ObjetivoIndicador { get; set; }
        public byte? TendenciaIndicador { get; set; }
        public string Conclusiones { get; set; }
        public bool? Pca { get; set; }
        public string Incumplimiento { get; set; }
        public bool? Metric { get; set; }
        public bool? Status { get; set; }
        public DateTime? FechaCierre { get; set; }
        public int? PlantaId { get; set; }
        public int? UsuarioRegistroId { get; set; }
        public int? UsuarioCierreId { get; set; }
        public int? AccumulatedMonth { get; set; }
        public byte? ObjetivoYtd { get; set; }
        public bool? Encendido { get; set; }
    }
}
