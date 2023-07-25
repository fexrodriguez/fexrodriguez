using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class SoftwareConfigMainMenuTemporaryApprover
    {
        public int IdRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioTemporalId { get; set; }
        public bool? Status { get; set; }
        public int MenuSeccionId { get; set; }
        public bool Administrator { get; set; }
        public int? AdminId { get; set; }
        public DateTime? FechaLiberacion { get; set; }
    }
}
