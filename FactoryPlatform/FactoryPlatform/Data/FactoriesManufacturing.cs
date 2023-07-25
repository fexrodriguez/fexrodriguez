using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class FactoriesManufacturing
    {
        public int IdFabricante { get; set; }
        public string Fabricante { get; set; }
        public string Descripcion { get; set; }
        public int TipoFabricante { get; set; }
        public string Color { get; set; }
        public bool? Status { get; set; }
    }
}
