using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesMatrixSkills
    {
        public int IdRegistro { get; set; }
        public int UsuarioId { get; set; }
        public int EstacionId { get; set; }
        public byte NivelConocimiento { get; set; }
        public DateTime? FechaLilberacionFaseHabilidad { get; set; }
        public DateTime? FechaCursoInstructorInterno { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? UsuarioRegistroId { get; set; }
    }
}
