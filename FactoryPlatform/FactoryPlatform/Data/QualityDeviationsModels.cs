using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityDeviationsModels
    {
        public int IdRegistro { get; set; }
        public int? RegistroDesviacionId { get; set; }
        public string Modelo { get; set; }
        public bool? Status { get; set; }
    }
}
