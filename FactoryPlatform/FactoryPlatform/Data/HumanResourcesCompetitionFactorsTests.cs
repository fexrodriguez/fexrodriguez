using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesCompetitionFactorsTests
    {
        public int IdExamen { get; set; }
        public int EstacionId { get; set; }
        public int CambioNivelId { get; set; }
        public int FactorCompetenciaId { get; set; }
        public decimal PorcentajeAprobacion { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool? Status { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? UsuarioBajaId { get; set; }
    }
}
