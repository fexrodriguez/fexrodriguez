using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesSurveysResultsResp16102020
    {
        public int RegistroId { get; set; }
        public string NumEmp { get; set; }
        public int? PreguntaId { get; set; }
        public int? Valor { get; set; }
        public string Calificacion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public bool? Status { get; set; }
    }
}
