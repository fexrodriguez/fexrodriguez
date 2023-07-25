using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class FinancesRequisitionsAuth
    {
        public int IdRegistro { get; set; }
        public int RequisicionId { get; set; }
        public int UsuarioAutorizacionId { get; set; }
        public int Nivel { get; set; }
        public int Orden { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public bool? Status { get; set; }
    }
}
