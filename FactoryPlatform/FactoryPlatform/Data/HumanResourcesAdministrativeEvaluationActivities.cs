using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesAdministrativeEvaluationActivities
    {
        public int IdRegistro { get; set; }
        public string Actividad { get; set; }
        public int? Cumplimiento { get; set; }
        public string Razones { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? Year { get; set; }
        public int EmployeeId { get; set; }
        public bool? Status { get; set; }
        public int? EvaluationId { get; set; }
        public int? TipoEvaluacionId { get; set; }
        public string Meta { get; set; }
        public string Observaciones { get; set; }
    }
}
