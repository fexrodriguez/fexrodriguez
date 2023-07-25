using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesJobDescription
    {
        public int IdRegistro { get; set; }
        public int JobId { get; set; }
        public int Belongs { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Purpose { get; set; }
        public bool? Status { get; set; }
    }
}
