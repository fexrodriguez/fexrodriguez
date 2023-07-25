using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesJobDescriptionResponsibility
    {
        public int IdRegistro { get; set; }
        public int JobId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public string Responsibility { get; set; }
        public byte Type { get; set; }
        public string Criterion { get; set; }
        public bool? Status { get; set; }
    }
}
