using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class ProductionMissingItemsCriticalParts
    {
        public int IdParteCritica { get; set; }
        public int? CodigoParte { get; set; }
        public string DescripcionParte { get; set; }
        public int? CodigoGarantia { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? UsuarioRegistroParteId { get; set; }
        public bool? Status { get; set; }
    }
}
