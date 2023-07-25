using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityWorkstationsLinkToCodesStations
    {
        public int IdRegistro { get; set; }
        public string Codigo { get; set; }
        public int WorkstationId { get; set; }
    }
}
