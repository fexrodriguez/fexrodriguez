using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class ProductionMotorsSequences
    {
        public int IdRegistro { get; set; }
        public string Modelo { get; set; }
        public int PruebaId { get; set; }
        public byte Secuencia { get; set; }
        public int? PlantaId { get; set; }
    }
}
