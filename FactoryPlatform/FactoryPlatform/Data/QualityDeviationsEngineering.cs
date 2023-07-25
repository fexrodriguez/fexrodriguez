using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityDeviationsEngineering
    {
        public int IdRegistro { get; set; }
        public int DeviationId { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string JobsId { get; set; }
        public string Description { get; set; }
        public int? ResponsableId { get; set; }
        public string Determination { get; set; }
    }
}
