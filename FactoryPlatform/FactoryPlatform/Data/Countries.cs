using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class Countries
    {
        public int IdPais { get; set; }
        public string NombreCorto { get; set; }
        public string Pais { get; set; }
    }
}
