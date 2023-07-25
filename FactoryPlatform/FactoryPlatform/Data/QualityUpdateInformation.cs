using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityUpdateInformation
    {
        public int Registro { get; set; }
        public string Estacion { get; set; }
        public bool? Pantalla { get; set; }
        public bool? Carpeta { get; set; }
    }
}
