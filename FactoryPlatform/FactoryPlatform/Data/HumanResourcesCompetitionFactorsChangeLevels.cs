﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesCompetitionFactorsChangeLevels
    {
        public int IdCambioNivel { get; set; }
        public int FactorCompetenciaId { get; set; }
        public int EstacionId { get; set; }
        public byte CambioNivelCompetencia { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? UsuarioBaja { get; set; }
        public bool? Status { get; set; }
    }
}
