using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesAdministrativeEvaluation
    {
        public int IdRegistro { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime FechaEvaluacion { get; set; }
        public int UsuarioRegistroId { get; set; }
        public int Periodo { get; set; }
        public string CommentsEvaluator { get; set; }
        public string CommentsEvaluated { get; set; }
        public string Comments { get; set; }
        public string StrategicPlanning { get; set; }
        public bool? CodeEthics { get; set; }
        public DateTime? DateEthics { get; set; }
        public byte? Status { get; set; }
        public int? EvaluacionId { get; set; }
        public int? TipoEvaluacionId { get; set; }
    }
}
