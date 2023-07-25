using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityCaSources
    {
        public int IdFuente { get; set; }
        public string Fuente { get; set; }
        public bool? Status { get; set; }
        public int? PlantaId { get; set; }
    }
}
