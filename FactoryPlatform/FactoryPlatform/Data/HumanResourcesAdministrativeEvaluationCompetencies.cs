using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesAdministrativeEvaluationCompetencies
    {
        public int IdRegistro { get; set; }
        public string Formacion { get; set; }
        public bool? Cuenta { get; set; }
        public bool? Actualizacion { get; set; }
        public bool? NoCuenta { get; set; }
        public string Razon { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public int EmployeeId { get; set; }
        public int Year { get; set; }
        public int? EvaluationId { get; set; }
    }
}
