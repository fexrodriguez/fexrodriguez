using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityWarrantiesUploadLog
    {
        public int RegistroId { get; set; }
        public int? Tipo { get; set; }
        public int? UsuarioRegistroId { get; set; }
        public DateTimeOffset? FechaRegistro { get; set; }
        public string UltimoDato { get; set; }
        public bool? Status { get; set; }
    }
}
