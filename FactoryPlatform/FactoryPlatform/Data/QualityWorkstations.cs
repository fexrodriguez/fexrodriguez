using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityWorkstations
    {
        public int IdWorkstation { get; set; }
        public string Workstation { get; set; }
        public int PrimaryMin { get; set; }
        public int PrimaryMax { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public int? PlantaId { get; set; }
    }
}
