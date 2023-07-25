using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class Towns
    {
        public int IdMunicipio { get; set; }
        public string Municipio { get; set; }
        public int EstadoId { get; set; }
    }
}
