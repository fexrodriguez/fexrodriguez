using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityPerformanceIndicatorsChangescomments
    {
        public int IdRegistro { get; set; }
        public string ConclusionesAnteriores { get; set; }
        public string ConclusionesNuevo { get; set; }
        public bool Pca { get; set; }
        public int IndicadorId { get; set; }
        public string IncumplimientoAnterior { get; set; }
        public string IncumplimientoNuevo { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistroId { get; set; }
        public int? PlantaId { get; set; }
    }
}
