using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityDeviations
    {
        public int IdRegistro { get; set; }
        public string Desviacion { get; set; }
        public string CodigoGarantia { get; set; }
        public int? RequestId { get; set; }
        public int? CantidadMotores { get; set; }
        public int? CantidadAnterior { get; set; }
        public int? CantidadMotoresDif { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? UsuarioRegistroId { get; set; }
        public string Comentarios { get; set; }
        public bool? Status { get; set; }
    }
}
