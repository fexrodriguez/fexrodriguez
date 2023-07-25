using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesTrainingEmployeesTestsResults
    {
        public int IdRegistro { get; set; }
        public int PreguntaId { get; set; }
        public int RespuestaId { get; set; }
        public bool Correcto { get; set; }
        public int ExamenId { get; set; }
        public int ExamenEmpleadoId { get; set; }
    }
}
