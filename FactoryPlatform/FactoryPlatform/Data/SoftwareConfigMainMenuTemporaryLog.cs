using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class SoftwareConfigMainMenuTemporaryLog
    {
        public int IdRegistro { get; set; }
        public int MenuSeccionId { get; set; }
        public int UsuarioOrigenId { get; set; }
        public int UsuiarioTemporalId { get; set; }
        public DateTime FechaCambio { get; set; }
        public int ForeignId { get; set; }
        public int? Nivel { get; set; }
        public bool? Status { get; set; }
    }
}
