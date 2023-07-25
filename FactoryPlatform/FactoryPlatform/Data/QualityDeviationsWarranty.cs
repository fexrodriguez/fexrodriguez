using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityDeviationsWarranty
    {
        public int IdRegistro { get; set; }
        public int DesviationId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public string Comentario { get; set; }
        public string MetodoTrazabilidad { get; set; }
        public int? ResponsableTrazabilidadId { get; set; }
    }
}
