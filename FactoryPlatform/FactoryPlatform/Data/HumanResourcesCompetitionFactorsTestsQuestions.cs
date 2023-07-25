using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesCompetitionFactorsTestsQuestions
    {
        public int IdPregunta { get; set; }
        public string Pregunta { get; set; }
        public bool? Status { get; set; }
        public byte TipoPregunta { get; set; }
        public int ExamenId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? UsuarioBajaId { get; set; }
    }
}
