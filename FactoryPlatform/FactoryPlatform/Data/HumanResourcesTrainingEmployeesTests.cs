using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesTrainingEmployeesTests
    {
        public int IdRegistro { get; set; }
        public int ExamenId { get; set; }
        public int UsuarioRegistroId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public DateTime? FechaPresentacion { get; set; }
        public decimal? ResultadoFinal { get; set; }
        public bool? Aprobado { get; set; }
    }
}
