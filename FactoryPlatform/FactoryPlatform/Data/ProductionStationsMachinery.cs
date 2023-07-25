using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class ProductionStationsMachinery
    {
        public int EstacionId { get; set; }
        public int MaquinaId { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
