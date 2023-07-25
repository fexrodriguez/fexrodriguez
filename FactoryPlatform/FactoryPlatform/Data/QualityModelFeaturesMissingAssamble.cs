using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityModelFeaturesMissingAssamble
    {
        public int IdRegistro { get; set; }
        public string Serie { get; set; }
        public string Modelo { get; set; }
        public byte? Ensamble1 { get; set; }
        public byte? Ensamble2 { get; set; }
        public byte? Ensamble3 { get; set; }
        public byte? Ensamble4 { get; set; }
        public byte? Ensamble5 { get; set; }
        public byte? Ensamble6 { get; set; }
        public byte? BlockCig { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
