﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityAuditsInput
    {
        public int IdAuditoria { get; set; }
        public int? TipoAuditoriaId { get; set; }
        public int? LineaId { get; set; }
        public int? EstacionId { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? UsuarioRegistroId { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? UsuarioBajaId { get; set; }
        public bool? Status { get; set; }
    }
}
