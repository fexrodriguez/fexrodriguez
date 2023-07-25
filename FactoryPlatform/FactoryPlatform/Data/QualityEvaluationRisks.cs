using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityEvaluationRisks
    {
        public int IdRegistro { get; set; }
        public int Proceso { get; set; }
        public string Mes { get; set; }
        public string Evento { get; set; }
        public string Efectos { get; set; }
        public string Descripcion { get; set; }
        public string Actual { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistro { get; set; }
    }
}
