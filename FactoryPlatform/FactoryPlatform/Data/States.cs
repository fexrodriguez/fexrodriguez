using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class States
    {
        public int IdEstado { get; set; }
        public string Estado { get; set; }
        public string NombreCorto { get; set; }
        public int PaisId { get; set; }
    }
}
