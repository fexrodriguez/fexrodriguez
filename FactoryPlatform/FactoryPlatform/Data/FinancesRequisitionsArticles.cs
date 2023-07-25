using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class FinancesRequisitionsArticles
    {
        public int IdRegistro { get; set; }
        public int? RequisicionId { get; set; }
        public string Articulo { get; set; }
        public string Descripcion { get; set; }
        public int? Cantidad { get; set; }
        public double? Unitario { get; set; }
        public double? Costo { get; set; }
        public bool? Status { get; set; }
    }
}
