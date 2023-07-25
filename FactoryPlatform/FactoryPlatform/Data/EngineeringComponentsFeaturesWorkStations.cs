using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringComponentsFeaturesWorkStations
    {
        public int IdRegistro { get; set; }
        public int CaracteristicaId { get; set; }
        public int TipoId { get; set; }
        public int EstacionId { get; set; }
        public bool? Status { get; set; }
    }
}
