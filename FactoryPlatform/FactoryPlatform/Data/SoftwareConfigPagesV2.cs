using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class SoftwareConfigPagesV2
    {
        public int IdPagina { get; set; }
        public string TituloPagina { get; set; }
        public bool? Status { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Direccion { get; set; }
        public string DireccionUrl { get; set; }
        public int SeccionId { get; set; }
        public int? SubSeccionId { get; set; }
        public string Tipo { get; set; }
    }
}
